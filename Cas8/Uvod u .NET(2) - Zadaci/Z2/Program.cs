using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Unesite datum:");
            DateTime datum;

            while (!DateTime.TryParse(Console.ReadLine(), out datum))
            {
                Console.WriteLine("Niste dobro uneli datum, unesite ponovo");
            }

            Console.WriteLine("Unesite skolu: ");
            string skola = Console.ReadLine();

            Console.WriteLine("Unesite razred");
            int razred;

            while (!int.TryParse(Console.ReadLine(), out razred) || razred<1 || razred>4)
            {
                Console.WriteLine("Razred mora biti celobrojna vrednost izmedju 1 i 4, unesite ponovo");
            }

            Ucenik ucenik = new Ucenik(ime, datum, skola, razred);

            Serijalizacija.Serijalizuj(args[0], ucenik);
            Console.WriteLine("Deserijalizovan ucenik {0}", Serijalizacija.Deserijalizuj(args[0]));
        }
    }
}
