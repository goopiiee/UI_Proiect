using System;

namespace aplicatie
{
    class program
    {
        static void Main(string[] args)
        {
           produse p1=new produse("Salam de sibiu","Mezeluri",1,21);
           p1.get_product_data();
           Console.WriteLine();
           useri u1=new useri("Ion","Barbu",21);
           u1.get_data();

        }
    }
}