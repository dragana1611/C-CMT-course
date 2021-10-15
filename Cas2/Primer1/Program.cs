using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime, prezime, skola;
            int godinaRodjenja, razred;

            Console.WriteLine("Unesite ime :");
            ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime :");
            prezime = Console.ReadLine();

            Console.WriteLine("Unesite skolu :");
            skola = Console.ReadLine();

            Console.WriteLine("Unesite godinu rodjenja :");
            godinaRodjenja = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite razred :");
            razred = Convert.ToInt32(Console.ReadLine());


            int x = 2021 - godinaRodjenja;

            Console.Clear();
            string ispis = "Korisnik " + ime + " " + prezime + "pohadja " + skola + " i ide u " + "razred, i ima godina " + x;

            Console.Write(ispis);
            Console.ReadKey();



        }
    }
}
