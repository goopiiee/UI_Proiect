﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class clienti
    {
        private string nume;
        private string prenume;
        private string adresa;
        public clienti()
        {
            nume = string.Empty;
            prenume = string.Empty;
            adresa = string.Empty;
        }
        public clienti(string nume,string prenume,string adresa)
        {
            this.nume = nume;
            this.prenume = prenume; 
            this.adresa = adresa;
        }
        public string Nume { get { return nume; } set { } }
        public string Prenume { get { return prenume; } set { } }
        public string Adresa { get { return adresa; } set { } }
        public string Get_data() { return nume + " | " + prenume + " | " + adresa; }
    }
}
