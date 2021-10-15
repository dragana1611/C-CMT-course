using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4___Stringovi
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Zdravo";
            string strKopija = str;
            str += " Svete!";               // Operator kreira novi string

            Console.WriteLine(str);
            Console.WriteLine(strKopija);

            Console.WriteLine();

            StringBuilder strBuilder = new StringBuilder("Zdravo");
            StringBuilder strBuilderKopija = strBuilder;

            strBuilder.Append(" Svete!");   // Metoda dodaje novi string postojećem stringu

            Console.WriteLine(strBuilder);
            Console.WriteLine(strBuilderKopija);

            Console.WriteLine();


        }
    }
}
