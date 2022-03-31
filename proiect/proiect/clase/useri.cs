using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class useri
    {
        private string nume;
        private string prenume;
        private int ID;
        useri()
        {
            ID = 0;
            nume=string.Empty;
            prenume=string.Empty;
        }
        useri(string nume,string prenume,int ID)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.ID = ID;
        }
        public string Nume { get { return nume; } set { nume = value; } }
        public string Prenume { get { return prenume; } set { prenume = value; } }
        public int _ID { get { return ID; } set { ID = value; } }
        public void Get_Data() { Console.WriteLine(nume + " | " + prenume + " | " + ID); }
    }
}
