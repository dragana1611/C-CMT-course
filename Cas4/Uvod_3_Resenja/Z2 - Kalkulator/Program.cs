using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2___Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator();

            int rez = kalkulator.Saberi(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("Zbir brojeva od 1 do 10 je {0}", rez);

            kalkulator.Oduzmi(out rez, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("Razlika brojeva od 1 do 10 je {0}", rez);

            Console.WriteLine("7 / 3 = {0}", kalkulator.Podeli(7, 3));
            Console.WriteLine("7 * 3 = {0}", kalkulator.Pomnozi(7, 3));

            rez = 7;
            kalkulator.Uvecaj(ref rez, 3);
            Console.WriteLine("7 + 3 = {0}", rez);

            Console.ReadKey();
        }
    }
}
