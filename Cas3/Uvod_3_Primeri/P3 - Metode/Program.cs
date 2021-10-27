using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3___Metode
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj=0;

            Inkrement(broj);
            Console.WriteLine("Nakon izlaska iz funkcije : {0}", broj);
            Inkrement(ref broj);
            Console.WriteLine("Nakon izlaska iz funkcije : {0}", broj);

            int rezultat;
            ZbirBrojeva(out rezultat, 1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine("Rezultat je {0}", rezultat);

            Console.ReadKey();
        }

        // 'Value' tip kao ulazni parametar
        static void Inkrement(int broj)
        {
            broj++;
            Console.WriteLine("Unutar funkcije : {0}", broj);
        }


        // Referentni tip kao ulazni parametar
        static void Inkrement(ref int broj)
        {
            broj++;
            Console.WriteLine("Unutar funkcije : {0}", broj);
        }
                     

        // Proizvoljan broj ulaznih parametara, ulazno-izlazni parametar
        static void ZbirBrojeva(out int rezultat, params int[] brojevi)
        {
            rezultat = 0;

            for (int i = 0; i < brojevi.Count(); i++)
            {
                rezultat += brojevi[i];
            }

        }
    }
}
