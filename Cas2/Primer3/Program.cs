using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; 
            int b = 20;

            if (a > b)
            {
                Console.WriteLine("a je vece");
            }
            else if (a < b)
            {
                Console.WriteLine("b je vece");
            }
            else
            {
                Console.WriteLine("a i b su jednaki");
            }

            string rezultat = a == 0 ? "jeste" : "nije";
            Console.WriteLine(rezultat);

            switch (a)
            {
                case 10: Console.WriteLine("a ima vrednost 10");
                    break;
                //case 10: onda ne mora break
                    
                case 20: Console.WriteLine("a ima vrednost 10");
                    break;
                default:
                    Console.WriteLine("a ima vrednost 10");
                        break;
            }

            int[] x = new int[] { 1, 2, 3 };

            foreach(int v in x)
            {
                Console.WriteLine(v);
                if (v > 0) continue;
                Console.WriteLine(v);
            }


            Console.ReadLine();
        }
    }
}
