using System;
// TODO 
// > Citire date fisier
namespace aplicatie
{
    public class clienti
    {
        private const char separator=';';
        public string nume;
        public string prenume;
        public string adresa;
        public clienti(){nume=prenume=adresa="NULL";} // constructor implicit
        public clienti(string nume,string prenume,string adresa) // constructor cu parametrii
        {
            this.nume=nume;
            this.prenume=prenume;
            this.adresa=adresa;
        }
        public string get_nume(){return nume;}
        public string get_prenume(){return prenume;}
        public string get_adresa(){return adresa;}
        public void set_client_data(string nume,string prenume,string adresa)
        {
            this.nume=nume;
            this.prenume=prenume;
            this.adresa=adresa;
            Console.WriteLine("Datele clientului au fost resetate cu succes!{0} | {1} | {2}",nume,prenume,adresa);
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                separator,
                (nume ?? " NECUNOSCUT "),
                (prenume ?? " NECUNOSCUT "),
                (adresa ?? "NECUNOSCUT "));
            return obiectStudentPentruFisier;
        }
        
    }
}