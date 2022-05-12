using System;
namespace Librarie_Modele
{
    public class Comenzi : Produse
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        public const int NUMAR_MAXIM_COMENZI = 1000;
        public const int NUMAR_MINIM_COMENZI = 1;

        private const int ID_COMANDA = 0;
        private const int METODA_DE_PLATA = 1;

        public int IdComanda { get; set; }
        public string Metoda_Plata { get; set; }


        public Comenzi()
        {
            Metoda_Plata = string.Empty;
            IdComanda = 0;
        }
        public Comenzi(int idcomanda, string metoda_plata)
        {
            Metoda_Plata = metoda_plata;
            IdComanda = idcomanda;
        }
        public Comenzi(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdComanda = Int32.Parse(dateFisier[ID_COMANDA]);
            Metoda_Plata = dateFisier[METODA_DE_PLATA];
        }
        public string ConversieLaSirPentruFisier()
        {
            string ObiectComenziPentruFisier = string.Format("{1}{0}{2}{0}",
            SEPARATOR_PRINCIPAL_FISIER,
            IdComanda.ToString(),
            (Metoda_Plata ?? "Necunoscut")
            );
            return ObiectComenziPentruFisier;
        }
    }
}