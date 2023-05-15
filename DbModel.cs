using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiada_CSharp_2017_Nationala
{
    public class DbModel
    {
        public List<Utilizator> Utilizatori { get; set; }
        public List<Vacanta> Vacante{ get; set; }
        public List<Rezervare> Rezervari{ get; set; }
        public string SavedEmail { get; set; }
        public int GetNrLocuriLibere(Vacanta vac, DateTime start, DateTime end)
        {
            int oc = 0;
            foreach (var rez in Rezervari)
                if (rez.IdVacanta == vac.IdVacanta && !(start.Date > rez.DataSfarsit.Date || end < rez.DataInceput.Date) )
                {
                    oc += rez.NrPersoane;
                }
            return vac.NrLocuri - oc;
        }
    }

    public class Utilizator
    {
        public int IdUser { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }
        public int TipCont { get; set; }
    }

    public class Vacanta
    {
        public int IdVacanta { get; set; }
        public string NumeVacanta { get; set; } = "";
        public string Descriere { get; set; } = "";
        public string CaleFisier { get; set; } = "";
        public float Pret { get; set; } 
        public int NrLocuri { get; set; }
    }

    public class Rezervare
    {
        public int IdRezervare { get; set; }
        public int IdVacanta { get; set; }
        public int IdUser { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public int NrPersoane { get; set; }
        public float PretTotal { get; set; }
    }
}
