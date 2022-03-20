using System;
namespace aplicatie
{
    public class useri
    {
        private string nume;
        private string prenume;
        private int ID;
        public useri()
        {
            nume="NULL";
            prenume="NULL";
            ID=-1;
        }
        public useri(string nume,string prenume,int ID)
        {
            this.nume=nume;
            this.prenume=prenume;
            this.ID=ID;
        }
        public void get_data(){Console.WriteLine("Utilizatorul cu ID < {0} > | < {1} > | < {2}> ",ID,nume,prenume);}
        public void set_data(string nume,string prenume)
        {
            this.nume=nume;
            this.prenume=prenume;
        }
    }
}