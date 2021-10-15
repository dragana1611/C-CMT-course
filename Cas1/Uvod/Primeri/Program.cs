using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeri
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 10;

            double j = 10.2;

            bool logVrednost = true;

            char karakter1 = 'a';
            char karakter2 = 'b';
            char karakter3 = ' ';
            char karakter4 = 'c';

            string s1 = (karakter1 + karakter2 + karakter3 + karakter4).ToString();
            string s2 = karakter1 + karakter2 + karakter3 + karakter4.ToString();
            string s3 = karakter1.ToString() + karakter2 + karakter3 + karakter4;
            string s4 = karakter1.ToString() + karakter2.ToString() + karakter3.ToString() + karakter4.ToString();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.WriteLine("Unesite neki tekst");
            string sTekst = Console.ReadLine();
            Console.WriteLine("Uneli ste sledeci tekst :" + sTekst);

            Console.WriteLine("Unesite ceo broj");
            int broj = int.Parse(Console.ReadLine());
            double kvadratBroja = Math.Pow(broj,2);
            Console.WriteLine("Kvadrat ovog broja je : " + kvadratBroja);

            DateTime trenutnoVreme = DateTime.Now;
            DateTime nekoVreme = new DateTime(2020, 10, 2);

            Console.WriteLine(trenutnoVreme);
            Console.WriteLine(nekoVreme);

            Console.ReadKey();

        }
    }
}
