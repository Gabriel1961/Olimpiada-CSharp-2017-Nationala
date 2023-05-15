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
    public partial class TransformaAdmin : Form
    {
        void GetUsers()
        {
            comboBox1.Items.Clear();
            foreach(var ut in Program.db.Utilizatori)
                if(ut.TipCont == 1)
                    comboBox1.Items.Add(ut.Email);
        }

        public TransformaAdmin()
        {
            InitializeComponent();
            GetUsers();
        }

        private void Renunta(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inregistreaza(object sender, EventArgs e)
        {
            var f = new FrmInregistrare();
            f.SetEmail(comboBox1.Text);
            f.ShowDialog();
            GetUsers();
        }

        private void Transforma(object sender, EventArgs e)
        {
            var uti = Program.db.Utilizatori.Find((ut) => ut.Email == comboBox1.Text);
            if (uti != null)
            {
                uti.TipCont = 0;
                MessageBox.Show("Transformat in admin!");
            }
            else
            {
                Inregistreaza(null,null);
            }
        }
    }
}
