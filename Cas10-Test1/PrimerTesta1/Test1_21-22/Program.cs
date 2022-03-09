using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_21_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u = new Ucenik("Petar", "Petrovic");
            Console.WriteLine(u.PredstaviSe());
            Console.WriteLine(u);
            u.UcitajOcene();
            Console.WriteLine(u);

            Srednjoskolac s = new Srednjoskolac("Iva", "Ivic", "prirodno-matematicki");
            Console.WriteLine(s.PredstaviSe());
            Console.WriteLine(s);
            s.UcitajOcene();
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
