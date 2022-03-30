using System;
namespace aplicatie
{
    public class produse
    {
        private string nume_fisier=@"D:\Programare\Github\UI_Proiect\produse.txt";
        private string denumire;
        private string categorie;
        private  int ID;
        private  decimal pret;
        public produse()
        {
            denumire="NULL";
            categorie="NULL";
            pret=-1;
            ID=-1;
        }
        public produse(string denumire,string categorie,int ID,decimal pret)
        {
            this.denumire=denumire;
            this.categorie=categorie;
            this.ID=ID;
            this.pret=pret;
        }
        public void get_product_data(){Console.WriteLine("Produsul cu ID {0}, denumire {1} din categoria {2} cu pretul {3}",ID,denumire,categorie,pret);}
        public void set_product_data(string denumire,string categorie,decimal pret)
        {
           this.denumire=denumire;
           this.categorie=categorie;
           this.pret=pret;
           Console.WriteLine("Datele produsului au fost salvate!{0} | {1} | {2} | {3} ",ID,denumire,categorie,pret);
        }
        public void get_file_data()
        {
            using(StreamReader reader = new StreamReader(nume_fisier))
            {
                string linie;
                while((linie=reader.ReadLine())!=null)
                {Console.WriteLine(linie);}
            }
        }
        public void write_file_data(produse p)
        {
            using(StreamWriter write_to_text = new StreamWriter(nume_fisier,true))
            {
                write_to_text.WriteLine(p.denumire + " | " + p.categorie + " | " + p.ID + " | " + p.pret);
            }
        }
        public void get_cmd_data()
        {
            Console.WriteLine("Introduceti datele noului produs ( denumire | categorie | ID | pret )");
            string denumire=Console.ReadLine();
            string categorie=Console.ReadLine();
            int ID=Convert.ToInt32(Console.ReadLine());
            decimal pret=Convert.ToDecimal(Console.ReadLine());
            produse p = new produse(denumire,categorie,ID,pret);
            write_file_data(p);
        }
    }
}
