using Librarie_Modele;
using System;
using System.IO;

namespace Nivel_Stocare_Date
{
    public class AdministrareUseriText
    {
        private const int NUMAR_MAXIM_USERI = 25;
        private string NumeFisier;

        public AdministrareUseriText(string NumeFisier)
        {
            this.NumeFisier = NumeFisier;
            Stream streamFisierText = File.Open(NumeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddUser(Useri user)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(NumeFisier, true))
            {
                streamWriterFisierText.WriteLine(user.ConversieLaSirPentruFisier());
            }
        }
        public Useri[] GetUseri(out int nrUseri)
        {
            Useri[] useri = new Useri[NUMAR_MAXIM_USERI];
            using (StreamReader streamReader = new StreamReader(NumeFisier))
            {
                string linieFisier;
                nrUseri = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    useri[nrUseri++] = new Useri(linieFisier);
                }
            }
            Array.Resize(ref useri, nrUseri);
            return useri;
        }
    }
}
