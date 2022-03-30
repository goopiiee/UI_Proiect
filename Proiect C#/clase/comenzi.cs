using System;
namespace aplicatie
{
    public class comenzi
    {
        private string nume_fisier=@"D:\Programare\Github\UI_Proiect\comenzi.txt";
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
        public void get_file_data()
        {
            using(StreamReader reader = new StreamReader(nume_fisier))
            {
                string linie;
                while((linie=reader.ReadLine())!=null)
                {Console.WriteLine(linie);}
            }
        }
        public void write_file_data(comenzi c)
        {
            using(StreamWriter write_to_text = new StreamWriter(nume_fisier,true))
            {
                write_to_text.WriteLine(c.numar_comanda + " | " + c.adresa + " | " + c.met_plata);
            }
        }
        public void get_cmd_data()
        {
            Console.WriteLine("Introduceti datele noii comenzi ( numar comanda | adresa | metoda de plata )");
            int numar_comanda=Convert.ToInt32(Console.ReadLine());
            string adresa=Console.ReadLine();
            string met_plata=Console.ReadLine();
            comenzi c = new comenzi(numar_comanda,adresa,met_plata);
            write_file_data(c);
        }
    }
}