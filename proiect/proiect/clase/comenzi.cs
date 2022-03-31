using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class comenzi : clienti
    {
        private int ID_Comanda;
        private string metoda_plata; // Cash sau card
        public comenzi()
        {
            ID_Comanda = 0;
            metoda_plata = string.Empty;
        }
        public comenzi(int ID_Comanda,string metoda_plata)
        {
            this.ID_Comanda = ID_Comanda;
            this.metoda_plata = metoda_plata;
        }
        public int ID_comanda { get { return ID_Comanda; } set { ID_Comanda = value; } }
        public string Metoda_plata { get { return metoda_plata; } set { metoda_plata = value; } }
        public void Get_Data() { Console.WriteLine(ID_comanda + " | " + metoda_plata); }
    }
}
