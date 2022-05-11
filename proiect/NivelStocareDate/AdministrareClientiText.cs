using Librarie_Modele;
using System;
using System.IO;

namespace Nivel_Stocare_Date
{
    public class AdministrareClientiText
    {
        private const int NUMAR_MAXIM_CLIENTI = 500;
        private string NumeFisierClienti;

        public AdministrareClientiText(string NumeFisierClienti)
        {
            this.NumeFisierClienti = NumeFisierClienti;
            Stream streamFisierText = File.Open(NumeFisierClienti, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddClient(Clienti client)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(NumeFisierClienti, true))
            {
                streamWriterFisierText.WriteLine(client.ConversieLaSirPentruFisier());
            }
        }
        public Clienti[] GetClienti(out int nrClienti)
        {
            Clienti[] clienti = new Clienti[NUMAR_MAXIM_CLIENTI];
            using (StreamReader streamReader = new StreamReader(NumeFisierClienti))
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
