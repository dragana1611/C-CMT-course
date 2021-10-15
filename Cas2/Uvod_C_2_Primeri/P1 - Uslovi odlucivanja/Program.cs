using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1___Uslovi_odlucivanja
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int rezultat = b / a;

            // if - else
            if (rezultat > 0)
            {
                Console.WriteLine("rezultat je veci od 0");
            }
            else if (rezultat < 0)
            {
                Console.WriteLine("rezultat je manji od 0");
            }
            else
            {
                Console.WriteLine("rezultat je jednak 0");
            }


            // switch - case
            switch (rezultat)
            {
                case 0:
                    {
                        Console.WriteLine("rezultat je jednak 0");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("rezultat je razlicit od 0");
                        break;
                    }
            }


            // uslovni operator ?
            string rezultatProvere = rezultat == 0 ? "rezultat je jednak 0" : "rezultat je razlicit od 0";
            Console.WriteLine(rezultatProvere);
        }
    }
}
