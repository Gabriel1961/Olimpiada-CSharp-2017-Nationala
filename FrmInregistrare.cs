using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimpiada_CSharp_2017_Nationala
{
    public partial class FrmInregistrare : Form
    {
        Random rand = new Random(DateTime.Now.Millisecond);
        string codCorect;
        public void SetEmail(string email)
        {
            tbEmail.Text = email;
        }
        void SetRandomImage()
        {
            var files = Directory.GetFiles("../../resurse/Logare");
            var idx = rand.Next() % files.Length;
            panel2.BackgroundImage = new Bitmap(files[idx]);
            var f = new FileInfo(files[idx]).Name;
            codCorect = f.Substring(0, f.IndexOf('.'));
        }

        public FrmInregistrare()
        {
            InitializeComponent();
            SetRandomImage();
        }


        bool CheckValid()
        {
            if (string.IsNullOrEmpty(tbNume.Text))
            {
                MessageBox.Show("Nume invalid.");
                return false; 
            }
            if (string.IsNullOrEmpty(tbPrenume.Text))
            {
                MessageBox.Show("Prenume invalid.");
                return false;
            }
            if (tbParola.Text != tbConfirmParola.Text)
            {
                MessageBox.Show("Parolele nu sunt la fel.");
                return false;
            }
            if (tbParola.Text.Length < 3)
            {
                MessageBox.Show("Parola prea scurta.");
                return false;
            }

            try
            {
                int idx = tbEmail.Text.LastIndexOf(".");
                if (idx == -1 || idx == tbEmail.Text.Length-1)
                    throw new Exception();
                MailAddress m = new MailAddress(tbEmail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email invalid.");
                return false;
            }

            if(Program.db.Utilizatori.Any((u)=>u.Email == tbEmail.Text))
            {
                MessageBox.Show("Utilizatorul cu acest email exista deja in baza de date.");
                return false;
            }

            if(tbCod.Text != codCorect)
            {
                MessageBox.Show("Cod incorect.");
                return false;
            }

            return true;
        }

        private void Inregistrare(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                var ut = new Utilizator()
                {
                    Email = tbEmail.Text,
                    IdUser = Program.db.Utilizatori.Count+1,
                    Nume = tbNume.Text,
                    Parola = tbParola.Text,
                    Prenume = tbPrenume.Text,
                    TipCont = 1,
                };
                Program.db.Utilizatori.Add(ut);
                MessageBox.Show("Cont inregistrat!");
                this.Close();
            }
            else
            {
                tbCod.Clear();
                tbConfirmParola.Clear();
                tbEmail.Clear();
                tbParola.Clear();
                tbNume.Clear();
                tbPrenume.Clear();
                SetRandomImage();
            }
        }

        private void Renunta(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
