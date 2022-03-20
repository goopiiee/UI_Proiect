using System;
namespace aplicatie
{
    public class produse
    {
        public string denumire;
        public string categorie;
        public int ID;
        public float pret;
        public produse()
        {
            denumire="NULL";
            categorie="NULL";
            pret=-1;
            ID=-1;
        }
        public produse(string denumire,string categorie,int ID,float pret)
        {
            this.denumire=denumire;
            this.categorie=categorie;
            this.ID=ID;
            this.pret=pret;
        }
        public void get_product_data(){Console.WriteLine("Produsul cu ID {0}, denumire {1} din categoria {2} cu pretul {3}",ID,denumire,categorie,pret);}
        public void set_product_data(string denumire,string categorie,float pret)
        {
           this.denumire=denumire;
           this.categorie=categorie;
           this.pret=pret;
           Console.WriteLine("Datele produsului au fost salvate!{0} | {1} | {2} | {3} ",ID,denumire,categorie,pret);
        }
    }
}