using Librarie_Modele;
using System;
using System.IO;

namespace Nivel_Stocare_Date
{
    public class AdministrareProduseText
    {
        private const int NUMAR_MAXIM_PRODUSE = 250;
        private string NumeFisier;

        public AdministrareProduseText(string NumeFisier)
        {
            this.NumeFisier = NumeFisier;
            Stream streamFisierText = File.Open(NumeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddProdus(Produse produs)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(NumeFisier, true))
            {
                streamWriterFisierText.WriteLine(produs.ConversieLaSirPentruFisier());
            }
        }
        public Produse[] GetProduse(out int nrProduse)
        {
            Produse[] produse = new Produse[NUMAR_MAXIM_PRODUSE];
            using (StreamReader streamReader = new StreamReader(NumeFisier))
            {
                string linieFisier;
                nrProduse = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    produse[nrProduse++] = new Produse(linieFisier);
                }
            }
            Array.Resize(ref produse, nrProduse);
            return produse;
        }
    }
}
