using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{

    struct Pracownik
    {

        public string imie;
        public string nazwisko;
        public long pesel;
        public double zarobki;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // struktury - sprawdzian2 - zestaw treningowy zad.3

            Pracownik czlowiek;

            Console.WriteLine("Podaj imie: ");
            czlowiek.imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            czlowiek.nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj numer PESEL: ");
            czlowiek.pesel = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Podaj zarobki: ");
            czlowiek.zarobki = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Pracownik {czlowiek.imie} {czlowiek.nazwisko} ({czlowiek.pesel}) zarabia {czlowiek.zarobki} zł.");

            Console.ReadKey();
        }
    }
}
