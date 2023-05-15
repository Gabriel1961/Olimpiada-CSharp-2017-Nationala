using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimpiada_CSharp_2017_Nationala
{
    public partial class Rezerva : Form
    {
        int nrLocuriLibere;
        float CalcPretTotal()
        {
            int pers = 0;
            int.TryParse(textBox1.Text, out pers);
            float pret = (float)(pers * vac.Pret *  (dateTimePicker2.Value.Date-dateTimePicker1.Value.Date).TotalDays);
            labPretTotal.Text = $"Pret total: {pret}";
            return pret;
        }

        void UpdateLocuriLibere()
        {
            labLocuri.Text = $"Numai {nrLocuriLibere} locuri libere ramase!";
            nrLocuriLibere = Program.db.GetNrLocuriLibere(vac, dateTimePicker1.Value, dateTimePicker2.Value);
        }

        Utilizator ut;
        Vacanta vac;
        public Rezerva(Utilizator ut, Vacanta vac)
        {
            this.ut = ut;
            this.vac = vac;
            InitializeComponent();
            this.Text = "Rezerva " + vac.NumeVacanta;
            labTitle.Text = vac.NumeVacanta;
            labDesc.Text = vac.Descriere;
            labPret.Text = vac.Pret.ToString("0.00");
            textBox1.Text = "1";

            dateTimePicker1.MinDate = DateTime.Now.Date;
            dateTimePicker2.MinDate = DateTime.Now.Date.AddDays(1);

            UpdateLocuriLibere();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            CalcPretTotal();
            UpdateLocuriLibere();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CalcPretTotal();
            UpdateLocuriLibere();
        }

        Rezervare rez;

        private void Confirma(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Data invalida!");
                return;
            }
            int pers = 0;
            
            if(int.TryParse(textBox1.Text,out pers)==false)
            {
                MessageBox.Show("Nr. invalid de persoane!");
                return;
            }

            if(pers > nrLocuriLibere)
            {
                MessageBox.Show("Nr. prea mare de persoane!");
                return;
            }
            rez = new Rezervare
            {
                DataInceput = dateTimePicker1.Value,
                DataSfarsit = dateTimePicker2.Value,
                IdRezervare = Program.db.Rezervari.Count + 1,
                IdUser = ut.IdUser,
                IdVacanta = vac.IdVacanta,
                NrPersoane = pers,
                PretTotal = CalcPretTotal()
            };
            Program.db.Rezervari.Add(rez);

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            PrintPreviewDialog d = new PrintPreviewDialog();
            d.Document = pd;
            MessageBox.Show("Rezervare efectuata!");
            d.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalcPretTotal();
        }


        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            var ft = new Font("verdana", 16);
            e.Graphics.DrawString($"Nume client: {ut.Nume}",ft,Brushes.Black,new PointF(0,10));
            e.Graphics.DrawString($"Email client: {ut.Email}",ft,Brushes.Black,new PointF(0,40));
            e.Graphics.DrawString($"Oferta: {vac.NumeVacanta}",ft,Brushes.Black,new PointF(0,70));
            e.Graphics.DrawString($"Data Inceput: {rez.DataInceput.ToShortDateString()}",ft,Brushes.Black,new PointF(0,100));
            e.Graphics.DrawString($"Data Sfarsit: {rez.DataSfarsit.ToShortDateString()}",ft,Brushes.Black,new PointF(0,130));
            e.Graphics.DrawString($"Nr persoane: {rez.NrPersoane}",ft,Brushes.Black,new PointF(0,160));
            e.Graphics.DrawString($"Total: {CalcPretTotal().ToString("0.00")}",ft,Brushes.Black,new PointF(0,190));
        }
    }
}
