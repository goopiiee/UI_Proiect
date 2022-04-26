using System;
namespace Librarie_Modele
{
    public class Useri
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        public const int NUMAR_MAXIM_USERI = 25;
        public const int NUMAR_MINIM_COMENZI = 1;

        private const int ID_USERI = 1;
        private const int NUME = 2;
        private const int PRENUME = 3;

        public int IdUser { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public Useri()
        {
            IdUser = 0;
            Nume = Prenume = string.Empty;
        }
        public Useri(string nume, string prenume)
        {
            Nume = nume;
            Prenume = prenume;
        }
        public Useri(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdUser = Int32.Parse(dateFisier[ID_USERI]);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
        }
        public string ConversieLaSirPentruFisier()
        {
            string ObiectUseriPentruFisier = string.Format("{1}{0}{2}{0}",
            SEPARATOR_PRINCIPAL_FISIER,
            IdUser.ToString(),
            (Nume ?? "Necunoscut"),
            (Prenume ?? "Necunoscut")
            );
            return ObiectUseriPentruFisier;
        }
    }
}