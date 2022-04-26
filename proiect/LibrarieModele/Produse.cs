using System;
namespace Librarie_Modele
{
    public class Produse
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        public const int NUMAR_MAXIM_PRODUSE = 250;
        public const int NUMAR_MINIM_COMENZI = 1;

        private const int ID_PRODUS = 1;
        private const int DENUMIRE = 2;
        private const int CATEGORIE = 3;
        private const int PRET = 4;

        public int IdProdus { get; set; }
        public string Denumire { get; set; }
        public string Categorie { get; set; }
        public decimal Pret { get; set; }

        public Produse()
        {
            IdProdus = 0; ;
            Pret = 0;
            Denumire = Categorie = string.Empty;
        }
        public Produse(string denumire, string categorie, decimal pret)
        {
            Pret = pret;
            Denumire = denumire;
            Categorie = categorie;
        }
        public Produse(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdProdus = Int32.Parse(dateFisier[ID_PRODUS]);
            Denumire = dateFisier[DENUMIRE];
            Categorie = dateFisier[CATEGORIE];
            Pret = decimal.Parse(dateFisier[PRET]);
        }
        public string ConversieLaSirPentruFisier()
        {
            string ObiectProdusePentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
            SEPARATOR_PRINCIPAL_FISIER,
            IdProdus.ToString(),
            (Denumire ?? "Necunoscut"),
            (Categorie ?? "Necunoscut"),
            Pret.ToString()
            );
            return ObiectProdusePentruFisier;
        }
    }
}