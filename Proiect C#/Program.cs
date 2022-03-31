using System;
// TODOLIST
// > Utilizare manager de fisiere in cadrul functiilor ce utilizeaza fisiere
// > Citire din fisier a datelor pentru fiecare clasa in parte
// > Citire de la tastatura si salvarea datelor in fisier
// > Cautare dupa unul sau mai multe criterii ( produse / comenzi )
// > Meniu cu fiecare clasa in parte,precum si submeniu cu fiecare optiune in parte ce contine : 
//  >> C - Citire informatii de la tastatura
//  >> F - Citire informatii din fisier
//  >> S - Salvare informatii in fisier
//  >> X - Iesire din program
//  >> H - Cautare dupa un anumit criteriu
//  >> A - Afisare informatii din fisier
namespace aplicatie
{
    class program
    {
        static void Main(string[] args)
        {
            // > Pentru useri
            useri u1=new useri();
            string optiune;
            do
            {
                Console.WriteLine("C > Citire informatii de la tastatura");
                Console.WriteLine("S > Salvare informatii in fisier");
                Console.WriteLine("F > Cautare dupa anumite criterii");
                Console.WriteLine("X > Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune=Console.ReadLine();
                switch(optiune.ToUpper())
                {
                   case "C" :
                        u1.get_cmd_data();
                        break;
                   case "S":
                        Console.WriteLine("done :)");
                        break;
                   case "X":
                        return;
                   default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            }while(optiune.ToUpper()!="X");

        }
    }
}
