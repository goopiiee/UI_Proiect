using Librarie_Modele;
using System;
using System.IO;

namespace Nivel_Stocare_Date
{
    public class AdministrareUseriText
    {
        private const int NUMAR_MAXIM_USERI = 25;
        private string NumeFisierUseri;

        public AdministrareUseriText(string NumeFisierUseri)
        {
            this.NumeFisierUseri = NumeFisierUseri;
            Stream streamFisierText = File.Open(NumeFisierUseri, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddUser(Useri user)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(NumeFisierUseri, true))
            {
                streamWriterFisierText.WriteLine(user.ConversieLaSirPentruFisier());
            }
        }
        public Useri[] GetUseri(out int nrUseri)
        {
            Useri[] useri = new Useri[NUMAR_MAXIM_USERI];
            using (StreamReader streamReader = new StreamReader(NumeFisierUseri))
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