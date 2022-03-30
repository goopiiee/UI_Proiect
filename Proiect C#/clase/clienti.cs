using System;
namespace aplicatie
{
    public class clienti
    {
        private string nume_fisier=@"D:\Programare\Github\UI_Proiect\clienti.txt";
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
        public void get_file_data()
        {
            using(StreamReader reader = new StreamReader(nume_fisier))
            {
                string linie;
                while((linie=reader.ReadLine())!=null)
                {Console.WriteLine(linie);}
            }
        }
        public void write_file_data(clienti c)
        {
            using(StreamWriter write_to_text = new StreamWriter(nume_fisier,true))
            {
                write_to_text.WriteLine(c.nume + " | " + c.prenume + " | " + c.adresa);
            }
        }
        public void get_cmd_data()
        {
            Console.WriteLine("Introduceti datele noului client ( nume | prenume | adresa )");
            string nume=Console.ReadLine();
            string prenume=Console.ReadLine();
            string adresa=Console.ReadLine();
            clienti c= new clienti(nume,prenume,adresa);
            write_file_data(c);
        }
    }
}