using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimpiada_CSharp_2017_Nationala
{
    public partial class FrmAutentificare : Form
    {
        public FrmAutentificare()
        {
            InitializeComponent();
            textBox1.Text = Program.db.SavedEmail;
        }

        private void Inregistrare(object sender, EventArgs e)
        {
            var f = new FrmInregistrare();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
            this.Hide();
        }

        private void Autentificare(object sender, EventArgs e)
        {
            var ut = Program.db.Utilizatori.Find((u) => u.Email == textBox1.Text && u.Parola == textBox2.Text);
            if (ut != null)
            {
                if (checkBox1.Checked)
                    Program.db.SavedEmail = ut.Email;
                else
                    Program.db.SavedEmail = "";
                if (checkBox1.Checked == false)
                    textBox1.Text = "";
                textBox2.Text = "";
                var f = new FrmVacanta(ut);
                f.FormClosed += (s, ev) =>{
                    if (f.deconectat)
                        this.Show();
                    else
                        this.Close();
                };
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eroare de autentificare!");
                textBox1.Clear();
                textBox2.Clear();
                Program.db.SavedEmail = "";
            }
        }
    }
}
