using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie_Modele
{
    public class Comenzi
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        public const int NUMAR_MAXIM_COMENZI = 1000;
        public const int NUMAR_MINIM_COMENZI = 1;

        private const int ID = 1;
        private const int METODA_PLATA = 2;

        // > Proprietati Auto-Implemented
        public int IdComanda { get; set; }
        public string MetodaPlata { get; set; } // > Cu cash sau card

        // > Constructor Implicit
        public Comenzi()
        {
            IdComanda = 0;
            MetodaPlata =string.Empty;
        }
        // > Constructor cu parametrii
        public Comenzi(int id,string metoda)
        {
            IdComanda=id;
            MetodaPlata =metoda;
        }
        // > Constructor care reprezinta o linie dintr-un fisier
        public Comenzi(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdComanda=Int32.Parse(dateFisier[ID]);
            MetodaPlata=dateFisier[METODA_PLATA];
        }
        public string ConversieLaSirPentruFisier()
        {
            string ObiectComenziPentruFisier = string.Format("{1}{0}{2}{0}",
            SEPARATOR_PRINCIPAL_FISIER,
            IdComanda.ToString(),
            (MetodaPlata ?? "Necunoscut")
            );
            return ObiectComenziPentruFisier;
        }
    }
}
