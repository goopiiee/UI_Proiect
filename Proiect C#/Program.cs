using System;
// TODOLIST
// > citire si afisare din fisier pentru fiecare clasa in parte [done/2]
// > Citire si salvare in fisier [done]
// > fara console la getline si setline [pending..]
// > Legare comenzi de produse [pending..]
// > Meniu [done]
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
