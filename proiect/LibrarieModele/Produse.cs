using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie_Modele
{
    public class Produse
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        public const int NUMAR_MAXIM_PRODUSE = 250;
        public const int NUMAR_MINIM_COMENZI = 1;

        private const int ID = 1;
        private const int DENUMIRE = 2;
        private const int CATEGORIE = 3;
        private const int PRET = 4;

        // > Proprietati Auto-Implemented
        public int IdProdus { get; set; }
        public string Denumire { get; set; }
        public string Categorie { get; set; }
        public decimal Pret { get; set; }

        // > Constructor Implicit
        public Produse()
        {
            IdProdus = 0;
            Denumire = Categorie = string.Empty;
            Pret = 0;
        }
        // > Constructor cu parametrii
        public Produse(int id,string denumire,string categorie, decimal pret)
        {
            IdProdus = id;
            Denumire = denumire;
            Categorie = categorie;
            Pret = pret;
        }
        // > Constructor care reprezinta o linie dintr-un fisier
        public Produse(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdProdus = Int32.Parse(dateFisier[ID]);
            Denumire = dateFisier[DENUMIRE];
            Categorie = dateFisier[CATEGORIE];
            Pret=decimal.Parse(dateFisier[PRET]);
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
