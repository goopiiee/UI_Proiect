using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie_Modele
{
    public class Useri
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        public const int NUMAR_MAXIM_USERI = 25;
        public const int NUMAR_MINIM_USERI = 1;

        private const int ID_USER = 1;
        private const int NUME = 2;
        private const int PRENUME = 3;

        // > Proprietati Auto-Implemented
        public int IdUser { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        // > Constructor Implicit
        public Useri()
        {
            IdUser = 0;
            Nume = Prenume = string.Empty;
        }
        // > Constructor cu parametrii
        public Useri(int id,string nume, string prenume)
        {
            IdUser = id;
            Nume = nume;
            Prenume = prenume;
        }
        // > Constructor care reprezinta o linie dintr-un fisier
        public Useri(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdUser=Int32.Parse(dateFisier[ID_USER]);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
        }
        public string ConversieLaSirPentruFisier()
        {
            string ObiectUseriPentruFisier = string.Format("{1}{0}{2}{0}{3}",
            SEPARATOR_PRINCIPAL_FISIER,
            IdUser.ToString(),
            (Nume ?? "Necunoscut"),
            (Prenume ?? "Necunoscut")
            );
            return ObiectUseriPentruFisier;
        }
    }
}
