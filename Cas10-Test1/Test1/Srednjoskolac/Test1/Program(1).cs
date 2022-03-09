using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Srednjoskolac s1 = new Srednjoskolac("Ivan", "Ivic", "Programiranje");
            Srednjoskolac s2 = new Srednjoskolac("Ivan", "Ivic", "Menadzment");
            Srednjoskolac s3 = new Srednjoskolac("Ivan", "Ivic", "Filozofija");
            Srednjoskolac s4 = new Srednjoskolac("Ivan", "Ivic", "Programiranje");

            Console.WriteLine(s1);           
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.ReadKey();
        }
    }
}
