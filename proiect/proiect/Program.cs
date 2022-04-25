using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using Librarie_Modele;
using Nivel_Stocare_Date;

namespace proiect
{
    public class Program
    {
        static void Main(string[] args)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            AdministrareClientiText administrareClienti = new AdministrareClientiText(caleCompletaFisier);
            Clienti ClientNou = new Clienti();
            int nrClienti = 0;
            administrareClienti.GetClienti(out nrClienti);

            char optiune;
            do
            {
                Console.WriteLine("C. Citire informatii client de la tastatura");
                Console.WriteLine("F. Afisare clienti din fisier");
                Console.WriteLine("S. Salvare client in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = char.Parse(Console.ReadLine());
                switch (optiune)
                {
                    case 'C':
                        ClientNou = citire_client_tastatura();
                        break;
                    case 'S':
                        int idClienti = nrClienti + 1;
                        ClientNou.IdClient = idClienti;
                        //adaugare student in fisier
                        administrareClienti.AddClient(ClientNou);
                        nrClienti++;
                        break;
                    case 'F':
                        Clienti[] clienti = administrareClienti.GetClienti(out nrClienti);
                        Afisare_Clienti(clienti, nrClienti);
                        break;
                    case 'X':
                        return;
                    default:
                        Console.WriteLine("Optiune Inexistenta");
                        break;

                }
            } while (optiune != 'X');
        }
        public static void Afisare_Client(Clienti client)
        {
            string infoClient = string.Format("Clientul cu id-ul #{0} are numele: {1} {2} si Adresa: {3}",
                    client.IdClient,
                    client.Nume ?? " NECUNOSCUT ",
                    client.Prenume ?? " NECUNOSCUT ",
                    client.Adresa ?? "NECUNOSCUT"
                    );

            Console.WriteLine(infoClient);
        }
        public static void Afisare_Clienti(Clienti[] clienti, int nrClienti)
        {
            Console.WriteLine("Clientii sunt");
            for (int contor = 0; contor < nrClienti; contor++)
            {
                Afisare_Client(clienti[contor]);
            }
        }
        public static Clienti citire_client_tastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele");
            string prenume = Console.ReadLine();

            Console.WriteLine("Introduceti Adresa");
            string adresa = Console.ReadLine();

            Clienti client = new Clienti(nume, prenume, adresa);
            return client;
        }
    }
}