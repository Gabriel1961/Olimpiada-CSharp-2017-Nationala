using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiada_CSharp_2017_Nationala
{
    public class DisplayVacanta
    {
        public string Vacanta { get; set; }
        [DisplayName("Data Inceput")]
        public string DataInceput { get; set; }
        [DisplayName("Data Final")]
        public string DataFinal{ get; set; }
        [DisplayName("Nr. Persoane")]
        public int NrPersoane { get; set; } 
        [DisplayName("Pret Total")]
        public string PretTotal { get => _PretTotal.ToString("0.00"); }

        private float _PretTotal;
        public int IdRezervare;
        public void SetPretTotal(float pret)
        {
            _PretTotal = pret;
        }
    }
}
