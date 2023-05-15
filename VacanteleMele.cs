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
    public partial class VacanteleMele : Form
    {
        Utilizator ut;
        void DisplayRez()
        {
            List<DisplayVacanta> ls = new List<DisplayVacanta>();
            foreach (var rez in Program.db.Rezervari)
                if (rez.IdUser == ut.IdUser)
                {
                    Vacanta vc = Program.db.Vacante[rez.IdVacanta - 1];
                    DisplayVacanta displayVacanta = new DisplayVacanta()
                    {
                        Vacanta = vc.NumeVacanta,
                        DataFinal = rez.DataSfarsit.ToShortDateString(),
                        DataInceput = rez.DataInceput.ToShortDateString(),
                        NrPersoane = rez.NrPersoane,
                        IdRezervare = rez.IdRezervare,
                    };
                    displayVacanta.SetPretTotal(rez.PretTotal);
                    ls.Add(displayVacanta);
                }

            DataGridViewButtonColumn but = new DataGridViewButtonColumn();
            but.UseColumnTextForButtonValue = true;
            but.Name = "Sterge";
            but.Text = "Sterge";
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ls;
            dataGridView1.Columns.Add(but);
        }

        public VacanteleMele(Utilizator ut)
        {
            this.ut = ut;
            InitializeComponent();

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            DisplayRez();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sterge")
            {
                var src = (List<DisplayVacanta>)dataGridView1.DataSource;
                Program.db.Rezervari.RemoveAt(src[e.RowIndex].IdRezervare - 1);
                DisplayRez();
            }
        }
    }
}
