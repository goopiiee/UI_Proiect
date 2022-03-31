using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class produse
    {
        private string denumire;
        private string categorie;
        private int ID;
        private decimal pret;
        produse()
        {
            denumire = string.Empty;
            categorie = string.Empty;
            ID = 0; 
            pret = 0M;
        }
        produse(string denumire,string categorie,int ID,decimal pret)
        {
            this.denumire = denumire;
            this.categorie = categorie;
            this.ID = ID;
            this.pret = pret;
        }
        public string Denumire { get { return denumire; } set { denumire = value; } }
        public string Categorie { get { return categorie; } set { categorie = value; } }
        public int _ID { get { return ID; } set { ID = value; } }
        public decimal Pret { get { return pret; } set { pret = value; } }
        public void Get_Data() { Console.WriteLine(denumire + " | " + categorie + " | " + ID + " | " + pret); }

    }
}
