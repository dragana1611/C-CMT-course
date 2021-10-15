using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5___Enumeracije
{
    class Program
    {
        // Deklaracija enumeracije
        enum GodisnjeDoba : byte { Zima = 0, Prolece, Leto, Jesen }

        static void Main(string[] args)
        {
            // Kreiranje novog objekta tipa enumeracije
            GodisnjeDoba godisnjeDoba = (GodisnjeDoba)(DateTime.Now.DayOfYear / 90);

            switch (godisnjeDoba)
            {
                case GodisnjeDoba.Zima:
                    {
                        Console.WriteLine("Danas je hladan zimski dan");
                        break;
                    }
                case GodisnjeDoba.Prolece:
                    {
                        Console.WriteLine("Danas je vedar prolećni dan");
                        break;
                    }
                case GodisnjeDoba.Leto:
                    {
                        Console.WriteLine("Danas je pakleni letnji dan");
                        break;
                    }
                case GodisnjeDoba.Jesen:
                    {
                        Console.WriteLine("Danas je tmuran jesenji dan");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nepoznato godišnje doba");
                        break;
                    }
            }
    }
}
