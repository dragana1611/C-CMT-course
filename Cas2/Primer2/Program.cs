using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            float k = 4;
            long h = 10l;
            Console.Write("Unesite stranicu a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Unesite stranicu b: ");
            b = double.Parse(Console.ReadLine());
            //int x = (int)4.5;
            int x = Convert.ToInt32(4.8);
            double obim, povrsina;
            obim = 2 * (a + b);
            //povrsina = k;
            povrsina = a * b;
            Console.WriteLine($"pravougaonik sa stranicama {a} i {b} ima povrsinu {povrsina} i obim {obim}");
            Console.ReadKey();

        }
    }
}
