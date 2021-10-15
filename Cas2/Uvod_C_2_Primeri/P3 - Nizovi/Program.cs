using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3___Nizovi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jednodimenzionalan niz veličine 5
            int[] brojevi = new int[5] { 0, 1, 2, 3, 4 };

            // Višedimenzionalan niz
            string[,] imena = new string[2, 3] { {"a", "b", "c"},
                                                 {"11", "12", "13"} };

            // Niz nizova
            // Nazubljen niz je niz čiji su elementi nizovi. Ovi elementi mogu biti nizovi različitih dimenzija i veličina
            byte[][] ocene = new byte[5][];

            // Kreiranje elemenata niza, tj. kreiranje nizova koji predstavljaju elemente niza
            for (int i = 0; i < ocene.Length; i++)
            {
                ocene[i] = new byte[i + 3];
            }

            // Ispis dužine svakog elementa 
            for (int i = 0; i < ocene.Length; i++)
            {
                Console.WriteLine("Duzina {0} elementa je {1}", i, ocene[i].Length);
            }

            Console.WriteLine();
        }
    }
}
