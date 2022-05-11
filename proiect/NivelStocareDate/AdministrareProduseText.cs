using Librarie_Modele;
using System;
using System.IO;

namespace Nivel_Stocare_Date
{
    public class AdministrareProduseText
    {
        private const int NUMAR_MAXIM_PRODUSE = 250;
        private string NumeFisierProduse;

        public AdministrareProduseText(string NumeFisierProduse)
        {
            this.NumeFisierProduse = NumeFisierProduse;
            Stream streamFisierText = File.Open(NumeFisierProduse, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddProdus(Produse produs)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(NumeFisierProduse, true))
            {
                streamWriterFisierText.WriteLine(produs.ConversieLaSirPentruFisier());
            }
        }
        public Produse[] GetProduse(out int nrProduse)
        {
            Produse[] produse = new Produse[NUMAR_MAXIM_PRODUSE];
            using (StreamReader streamReader = new StreamReader(NumeFisierProduse))
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
