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
    public partial class ModificaVacante : Form
    {

        public ModificaVacante()
        {
            InitializeComponent();
            DataGridViewButtonColumn but = new DataGridViewButtonColumn();
            but.UseColumnTextForButtonValue = true;
            but.Name = "Sterge";
            but.Text = "Sterge";
            dataGridView1.Columns.Add(but);

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = Program.db.Vacante;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.AllowUserToAddRows = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
                return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sterge")
            {
                Program.db.Vacante.RemoveAt(e.RowIndex);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Program.db.Vacante;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.db.Vacante.Add(new Vacanta() { IdVacanta=Program.db.Vacante.Count+1, });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.db.Vacante;
        }
    }
}
