using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizytowka
{

    struct Czlowiek {

        public string imie;
        public string nazwisko;
        public string adres_email;
        public string nr_telefonu;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek;

            Console.WriteLine("Podaj imie: ");
            czlowiek.imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            czlowiek.nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj adres e-mail: ");
            czlowiek.adres_email = Console.ReadLine();

            Console.WriteLine("Podaj numer telefonu: ");
            czlowiek.nr_telefonu = Console.ReadLine();

            // gwiazdki (nie przyjmujemy stałej liczby ale trzeba ją jakoś obliczyć) 
            for (int i = 0; i < 32; i++) Console.Write("*");
            Console.WriteLine();
            // imie+nazwisko // obliczyć ilość poprzedzających i spacji "za"
            Console.WriteLine("* " + czlowiek.imie + " " + czlowiek.nazwisko + " *");
            // adres
            Console.WriteLine("* " + czlowiek.adres_email + " *");
            // tel
            Console.WriteLine("* " + czlowiek.nr_telefonu + " *");
            //gwiazdki
            for (int i = 0; i < 32; i++) Console.Write("*");
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
