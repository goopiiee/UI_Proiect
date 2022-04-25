using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie_Modele
{
    public class Clienti
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        public const int NUMAR_MAXIM_CLIENTI = 100;
        public const int NUMAR_MINIM_CLIENTI = 1;

        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int ADRESA = 3;

        // > Proprietati Auto-Implemented
        public int IdClient { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }

        // > Constructor Implicit
        public Clienti()
        {
            Nume = Prenume = Adresa = string.Empty;
        }
        // > Constructor cu parametrii
        public Clienti(string nume, string prenume, string adresa)
        {
            Nume = nume;
            Prenume = prenume;
            Adresa = adresa;
        }
        // > Constructor care reprezinta o linie dintr-un fisier
        public Clienti(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
            Adresa = dateFisier[ADRESA];
        }
        public string ConversieLaSirPentruFisier()
        {
            string ObiectClientiPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
            SEPARATOR_PRINCIPAL_FISIER,
            (Nume ?? "Necunoscut"),
            (Prenume ?? "Necunoscut"),
            (Adresa ?? "Necunoscut")
            );
            return ObiectClientiPentruFisier;
        }
        static void Main(string[] args)
        {
        }
    }
}
