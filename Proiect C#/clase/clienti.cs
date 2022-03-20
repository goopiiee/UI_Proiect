using System;
namespace aplicatie
{
    public class clienti
    {
        private string nume;
        private string prenume;
        private string adresa;
        public clienti(){nume=prenume=adresa="NULL";}
        public clienti(string nume,string prenume,string adresa)
        {
            this.nume=nume;
            this.prenume=prenume;
            this.adresa=adresa;
        }
        public void get_client_data(){Console.WriteLine("Datele clientului sunt {0} | {1} | {2}",nume,prenume,adresa);}
        public void set_client_data(string nume,string prenume,string adresa)
        {
            this.nume=nume;
            this.prenume=prenume;
            this.adresa=adresa;
            Console.WriteLine("Datele clientului au fost resetate cu succes!{0} | {1} | {2}",nume,prenume,adresa);
        }
    }
}