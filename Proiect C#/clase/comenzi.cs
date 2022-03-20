using System;
namespace aplicatie
{
    public class comenzi
    {
        private int numar_comanda;
        private string adresa;
        private string met_plata; // cash,card
        public comenzi()
        {
            numar_comanda=-1;
            adresa=met_plata="NULL";
        }
        public comenzi(int numar_comanda,string adresa,string met_plata)
        {
            this.numar_comanda=numar_comanda;
            this.adresa=adresa;
            this.met_plata=met_plata;
        }
        public void get_order_data(){Console.WriteLine("Comanda cu Numar > {0} | Adresa > {1} | {2}",numar_comanda,adresa,met_plata);}
    }
}