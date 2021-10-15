using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2___Petlje
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocetnaVrednost = 0;
            int i;

            // while
            i = pocetnaVrednost;
            Console.WriteLine("Početak 'while' petlje");
            while (i < 10)
            {
                Console.Write(i + " ");
                ++i;
            }
            Console.WriteLine();
            Console.WriteLine("Kraj 'while' petlje");
            Console.WriteLine();

            // do while
            i = pocetnaVrednost;
            Console.WriteLine("Početak 'do - while' petlje");
            do
            {
                Console.Write(i + " "); // izvršiće se barem jednom
                ++i;
            } while (i < 10);
            Console.WriteLine();
            Console.WriteLine("Kraj 'do - while' petlje");
            Console.WriteLine();

            // for
            Console.WriteLine("Početak 'for' petlje");
            for (i = pocetnaVrednost; i < 10; ++i)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Kraj 'for' petlje");
            Console.WriteLine();

            // break i continue
            Console.WriteLine("Početak petlje sa 'continue' i 'break'");
            for (i = pocetnaVrednost; i < 10; ++i)
            {
                if ((i % 2) == 0)
                {
                    continue; // preskaće se trenutna iteracija
                }

                if ((i % 5) == 0)
                {
                    break; // izlazak iz petlje
                }

                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Kraj petlje sa 'continue' i 'break'");
            Console.WriteLine();

            // break i continue
            Console.WriteLine("Početak foreach petlje");
            int[] nizBrojeva = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int broj in nizBrojeva)
            {
                Console.Write(broj + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Kraj foreach petlje");
            Console.WriteLine();
        }
    }
}
