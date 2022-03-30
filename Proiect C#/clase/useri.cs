using System;
namespace aplicatie
{
    public class useri
    {
        private string nume;
        private string nume_fisier=@"D:\Programare\Github\UI_Proiect\useri.txt";
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
        public void get_file_data()
        {
            using(StreamReader reader = new StreamReader(nume_fisier))
            {
                string linie;
                while((linie=reader.ReadLine())!=null)
                {Console.WriteLine(linie);}
            }
        }
        public void write_file_data(useri u)
        {
            using(StreamWriter write_to_text = new StreamWriter(nume_fisier,true))
            {
                write_to_text.WriteLine(u.nume + " | " + u.prenume + " | " + u.ID);
            }
        }
        public void get_cmd_data()
        {
            Console.WriteLine("Introduceti datele noului user ( nume | prenume | ID )");
            string nume=Console.ReadLine();
            string prenume=Console.ReadLine();
            int ID=Convert.ToInt32(Console.ReadLine());
            useri u=new useri(nume,prenume,ID);
            write_file_data(u);
        }
        
    }
}
