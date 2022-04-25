using Librarie_Modele;
using System;
using System.IO;

namespace Nivel_Stocare_Date
{
    public class AdministrareComenziText
    {
        private const int NUMAR_MAXIM_COMENZI = 5000;
        private string NumeFisier;

        public AdministrareComenziText(string NumeFisier)
        {
            this.NumeFisier = NumeFisier;
            Stream streamFisierText = File.Open(NumeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddClient(Clienti client)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(NumeFisier, true))
            {
                streamWriterFisierText.WriteLine(client.ConversieLaSirPentruFisier());
            }
        }
        public Comenzi[] GetComenzi(out int nrComenzi)
        {
            Comenzi[] comenzi = new Comenzi[NUMAR_MAXIM_COMENZI];
            using (StreamReader streamReader = new StreamReader(NumeFisier))
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
