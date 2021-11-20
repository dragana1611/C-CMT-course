using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1___Koordinatne_tacke
{
    class Program
    {
        static void Main(string[] args)
        {
            KoordinatnaTacka a = new KoordinatnaTacka(5, 6);
            KoordinatnaTacka b = new KoordinatnaTacka(9, 3);

            Console.WriteLine("Rastojanje izmedju tacaka A{0} i B{1} je {2}", a, b, RastojanjeIzmedjuDveTacke(a, b));

            Console.ReadKey();
        }

        static double RastojanjeIzmedjuDveTacke(KoordinatnaTacka a, KoordinatnaTacka b)
        {
            double rezultat = 0, dx, dy;
            dx = a.X - b.X;
            dy = a.Y - b.Y;
            rezultat = Math.Sqrt(dx * dx + dy * dy);
            return rezultat;
        }
    }
}
