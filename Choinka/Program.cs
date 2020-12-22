using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {

            string nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj6\Sbox\choinka.txt";
            FileStream strumien = new FileStream(nazwa, FileMode.Append, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(strumien);

            // etap 1. Choinka
            Console.WriteLine("Podaj wysokość choinki: ");
            int.TryParse(Console.ReadLine(), out int n);

            int p = 2 * n - 1;  // szerokość choinki

            for (int i = 1; i <= n; i++) // pętla zewnętrzna, idziemy po wierszach
            {
                int x = 2 * i - 1; // x - ilość gwiazdek w i-tym wierszu

                // spacje po jednej stronie
                for (int k = 0; k < (p-x)/2; k++)
                {
                    zapis.Write(" ");
                }

                // gwiazdki
                for (int k = 0; k < x; k++)
                {
                    zapis.Write("*");
                }

                // spacje
                for (int k = 0; k < (p - x) / 2; k++)
                {
                    zapis.Write(" ");
                }

                // nowa linia
                zapis.WriteLine();
            }

            // etap 2. Zapis choinki do pliku



            // zapisywanie choinki do pliku

            zapis.Close();
            strumien.Close();
            Console.ReadKey();

        }
    }
}
