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
            void MeniuPrincipal()
            {
                char optiune_principala;
                do
                {
                    Console.WriteLine("Selectati Categoria");
                    Console.WriteLine("U - Useri");
                    Console.WriteLine("P - Produse");
                    Console.WriteLine("C - Clienti");
                    Console.WriteLine("O - Comenzi");
                    Console.WriteLine("X - Inchidere aplicatie");
                    optiune_principala = char.Parse(Console.ReadLine());
                    switch (optiune_principala)
                    {
                        case 'U':
                            MeniuUseri();
                            break;
                        case 'P':
                            MeniuProduse();
                            break;
                        case 'C':
                            MeniuClienti();
                            break;
                        case 'O':
                            MeniuComenzi();
                            break;
                        case 'X':
                            return;
                        default:
                            Console.WriteLine("Optiune inexistenta");
                            break;
                    }
                } while (optiune_principala != 'X');
            }

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            AdministrareClientiText administrareClienti = new AdministrareClientiText(caleCompletaFisier);
            Clienti ClientNou = new Clienti();
            int nrClienti = 0;
            administrareClienti.GetClienti(out nrClienti);

            AdministrareUseriText administrareUseri = new AdministrareUseriText(caleCompletaFisier);
            Useri UserNou = new Useri();
            int nrUseri = 0;
            administrareUseri.GetUseri(out nrUseri);


            AdministrareComenziText administrareComenzi = new AdministrareComenziText(caleCompletaFisier);
            Comenzi ComandaNoua = new Comenzi();
            int nrComenzi = 0;
            administrareComenzi.GetComenzi(out nrComenzi);

            AdministrareProduseText administrareProduse = new AdministrareProduseText(caleCompletaFisier);
            Produse ProdusNou = new Produse();
            int nrProduse = 0;
            administrareProduse.GetProduse(out nrProduse);

            MeniuPrincipal();
            void MeniuUseri()
            {
                char OptiuneUseri;
                do
                {
                    Console.WriteLine("---Useri---");
                    Console.WriteLine("C. Citire informatii user de la tastatura");
                    Console.WriteLine("F. Afisare useri din fisier");
                    Console.WriteLine("S. Salvare useri in fisier");
                    Console.WriteLine("B. Inapoi la meniul principal");
                    Console.WriteLine("Alegeti o optiune");
                    OptiuneUseri = char.Parse(Console.ReadLine());
                    switch (OptiuneUseri)
                    {
                        case 'C':
                            UserNou = CitireUseriTastatura();
                            break;
                        case 'S':
                            int idUseri = nrUseri + 1;
                            UserNou.IdUser = idUseri;
                            //adaugare student in fisier
                            administrareUseri.AddUser(UserNou);
                            nrUseri++;
                            break;
                        case 'F':
                            Useri[] useri = administrareUseri.GetUseri(out nrUseri);
                            AfisareUseri(useri, nrUseri);
                            break;
                        case 'B':
                            MeniuPrincipal();
                            break;
                        default:
                            Console.WriteLine("Optiune Inexistenta");
                            break;
                    }
                } while (OptiuneUseri != 'B');
            }
            void MeniuClienti()
            {
                char OptiuneClienti;
                do
                {
                    Console.WriteLine("---Clienti---");
                    Console.WriteLine("C. Citire informatii client de la tastatura");
                    Console.WriteLine("F. Afisare clienti din fisier");
                    Console.WriteLine("S. Salvare client in fisier");
                    Console.WriteLine("B. Inapoi la meniul principal");
                    Console.WriteLine("Alegeti o optiune");
                    OptiuneClienti = char.Parse(Console.ReadLine());
                    switch (OptiuneClienti)
                    {
                        case 'C':
                            ClientNou = CitireClientiTastatura();
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
                            AfisareClienti(clienti, nrClienti);
                            break;
                        case 'B':
                            MeniuPrincipal();
                            break;
                        default:
                            Console.WriteLine("Optiune Inexistenta");
                            break;
                    }
                } while (OptiuneClienti != 'B');
            }
            void MeniuProduse()
            {
                char OptiuneProduse;
                do
                {
                    Console.WriteLine("---Produse---");
                    Console.WriteLine("C. Citire informatii produs de la tastatura");
                    Console.WriteLine("F. Afisare produse din fisier");
                    Console.WriteLine("S. Salvare produs in fisier");
                    Console.WriteLine("B. Inapoi la meniul principal");
                    Console.WriteLine("Alegeti o optiune");
                    OptiuneProduse = char.Parse(Console.ReadLine());
                    switch (OptiuneProduse)
                    {
                        case 'C':
                            ProdusNou = CitireProduseTastatura();
                            break;
                        case 'S':
                            int idProdus = nrProduse + 1;
                            ProdusNou.IdProdus = idProdus;
                            administrareProduse.AddProdus(ProdusNou);
                            nrProduse++;
                            break;
                        case 'F':
                            Produse[] produse = administrareProduse.GetProduse(out nrProduse);
                            AfisareProduse(produse, nrProduse);
                            break;
                        case 'B':
                            MeniuPrincipal();
                            break;
                        default:
                            Console.WriteLine("Optiune Inexistenta");
                            break;
                    }
                } while (OptiuneProduse != 'B');
            }
            void MeniuComenzi()
            {
                char OptiuneComenzi;
                do
                {
                    Console.WriteLine("---Comenzi---");
                    Console.WriteLine("C. Citire informatii comanda de la tastatura");
                    Console.WriteLine("F. Afisare comenzi din fisier");
                    Console.WriteLine("S. Salvare comanda in fisier");
                    Console.WriteLine("B. Inapoi la meniul principal");
                    Console.WriteLine("Alegeti o optiune");
                    OptiuneComenzi = char.Parse(Console.ReadLine());
                    switch (OptiuneComenzi)
                    {
                        case 'C':
                            ComandaNoua = CitireComenziTastatura();
                            break;
                        case 'S':
                            int idComanda = nrComenzi + 1;
                            ComandaNoua.IdComanda = idComanda;
                            administrareComenzi.AddComenzi(ComandaNoua);
                            nrComenzi++;
                            break;
                        case 'F':
                            Comenzi[] comenzi=administrareComenzi.GetComenzi(out nrComenzi);
                            AfisareComenzi(comenzi, nrComenzi);
                            break;
                        case 'B':
                            MeniuPrincipal();
                            break;
                        default:
                            Console.WriteLine("Optiune Inexistenta");
                            break;
                    }
                } while (OptiuneComenzi != 'B');
            }
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
        public static void AfisareClienti(Clienti[] clienti, int nrClienti)
        {
            Console.WriteLine("Clientii sunt");
            for (int contor = 0; contor < nrClienti; contor++)
            {
                Afisare_Client(clienti[contor]);
            }
        }
        public static Clienti CitireClientiTastatura()
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

        public static void Afisare_User(Useri user)
        {
            string infoUseri = string.Format("Userul cu id-ul #{0} are numele: {1} {2}.",
                   user.IdUser,
                   user.Nume ?? " NECUNOSCUT ",
                   user.Prenume ?? " NECUNOSCUT "
                   );
            Console.WriteLine(infoUseri);
        }
        public static void AfisareUseri(Useri[] useri,int nrUseri)
        {
            Console.WriteLine("Userii sunt");
            for (int contor = 0; contor < nrUseri; contor++)
            {
                Afisare_User(useri[contor]);
            }
        }
        public static Useri CitireUseriTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele");
            string prenume = Console.ReadLine();

            Useri user = new Useri(nume, prenume);
            return user;
        }

        public static void Afisare_Produs(Produse produs)
        {
            string infoProduse = string.Format("Produsul cu id-ul #{0} are denumirea: {1}, categoria {2} si pretul  {3}.",
                  produs.IdProdus,
                  produs.Denumire ?? " NECUNOSCUT ",
                  produs.Categorie ?? " NECUNOSCUT ",
                  produs.Pret
                  );
            Console.WriteLine(infoProduse);
        }
        public static void AfisareProduse(Produse[] produse,int nrProduse)
        {
            Console.WriteLine("Produsele sunt");
            for (int contor = 0; contor < nrProduse; contor++)
            {
                Afisare_Produs(produse[contor]);
            }
        }
        public static Produse CitireProduseTastatura()
        {
            Console.WriteLine("Introduceti Denumirea");
            string denumirea = Console.ReadLine();

            Console.WriteLine("Introduceti Categoria");
            string categoria = Console.ReadLine();

            Console.WriteLine("Introduceri Pretul");
            decimal pret=decimal.Parse(Console.ReadLine());

            Produse produs = new Produse(denumirea,categoria,pret);
            return produs;
        }

        public static void Afisare_Comanda(Comenzi comanda)
        {
            string infoComenzi = string.Format("Comenda cu id-ul #{0} are metoda de plata {1}.",
                   comanda.IdComanda,
                   comanda.Metoda_Plata ?? "NECUNOSCUT"
                   ); ;
            Console.WriteLine(infoComenzi);
        }
        public static void AfisareComenzi(Comenzi[] comenzi,int nrComenzi)
        {
            Console.WriteLine("Comenzile sunt");
            for (int contor = 0; contor < nrComenzi; contor++)
            {
                Afisare_Comanda(comenzi[contor]);
            }
        }
        public static Comenzi CitireComenziTastatura()
        {
            int counter = 0;
            Console.WriteLine("Introduceti Metoda de plata");
            string metoda_de_plata = Console.ReadLine();
            Comenzi comanda=new Comenzi(counter, metoda_de_plata);
            counter++;
            return comanda;

        }
    }
}