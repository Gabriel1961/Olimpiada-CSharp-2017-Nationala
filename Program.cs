using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Olimpiada_CSharp_2017_Nationala
{
    internal static class Program
    {
        public static DbModel db;
        static void LoadDb()
        {
            if (File.Exists("../../TurismDB.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(DbModel));
                var f = File.OpenRead("../../TurismDB.xml");
                db = (DbModel)ser.Deserialize(f);
                f.Close();
            }
            else
            {
                db = new DbModel {
                    Rezervari = new List<Rezervare>(),
                    Utilizatori = new List<Utilizator>(),
                    Vacante = new List<Vacanta>()
                };
                var lines = File.ReadAllLines("../../resurse/Vacante.txt");
                int i = 1;
                foreach (var line in lines)
                {
                    var cuv = line.Split('|');
                    var vac = new Vacanta()
                    {
                        IdVacanta = i,
                        NumeVacanta = cuv[0],
                        CaleFisier = cuv[0],
                        Descriere = cuv[1],
                        Pret = float.Parse(cuv[2]),
                        NrLocuri = int.Parse(cuv[3]),
                    };
                    db.Vacante.Add(vac);
                    i++;
                }

                db.Utilizatori.Add(new Utilizator
                {
                    IdUser = 1,
                    Prenume = "admin",
                    Nume = "admin",
                    Email = "admin@oti.ro",
                    Parola = "oti2017",
                    TipCont = 0,
                });
            }
        }

        static void SaveDb()
        {
            XmlSerializer ser = new XmlSerializer(typeof(DbModel));
            var f = File.OpenWrite("../../TurismDB.xml");
            ser.Serialize(f,db);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadDb();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAutentificare());
            SaveDb();
        }
    }
}
