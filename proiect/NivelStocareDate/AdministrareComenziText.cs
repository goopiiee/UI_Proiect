using Librarie_Modele;
using System;
using System.IO;

namespace Nivel_Stocare_Date
{
    public class AdministrareComenziText
    {
        private const int NUMAR_MAXIM_COMENZI = 5000;
        private string NumeFisierComenzi;

        public AdministrareComenziText(string NumeFisierComenzi)
        {
            this.NumeFisierComenzi = NumeFisierComenzi;
            Stream streamFisierText = File.Open(NumeFisierComenzi, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddComenzi(Comenzi comanda)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(NumeFisierComenzi, true))
            {
                streamWriterFisierText.WriteLine(comanda.ConversieLaSirPentruFisier());
            }
        }
        public Comenzi[] GetComenzi(out int nrComenzi)
        {
            Comenzi[] comenzi = new Comenzi[NUMAR_MAXIM_COMENZI];
            using (StreamReader streamReader = new StreamReader(NumeFisierComenzi))
            {
                string linieFisier;
                nrComenzi = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    comenzi[nrComenzi++] = new Comenzi(linieFisier);
                }
            }
            Array.Resize(ref comenzi, nrComenzi);
            return comenzi;
        }
        static void Main(string[] args)
        {
        }
    }
}