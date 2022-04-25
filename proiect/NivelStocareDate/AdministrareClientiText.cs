using Librarie_Modele;
using System;
using System.IO;

namespace Nivel_Stocare_Date
{
    public class AdministrareClientiText
    {
        private const int NUMAR_MAXIM_CLIENTI = 500;
        private string NumeFisier;

        public AdministrareClientiText(string NumeFisier)
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
        public Clienti[] GetClienti(out int nrClienti)
        {
            Clienti[] clienti = new Clienti[NUMAR_MAXIM_CLIENTI];
            using (StreamReader streamReader = new StreamReader(NumeFisier))
            {
                string linieFisier;
                nrClienti = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    clienti[nrClienti++] = new Clienti(linieFisier);
                }
            }
            Array.Resize(ref clienti, nrClienti);
            return clienti;
        }
    }
}
