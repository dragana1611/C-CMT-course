using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arheolog
{

    class BazaPodataka
    {
        public static List<Arheolog> arheolozi = new List<Arheolog>();
        public static List<string> gradovi = new List<string>();
        public static List<string> drzave = new List<string>();
        static BazaPodataka(){
// Instanciranje Arheologa
        //            Predmet srpski_jezik = new Predmet("Srpski_jezik", "Mia Micic", 4, Tip.OBAVEZAN);
        Arheolog arh1 = new Arheolog("1", "Ana", "Anic", "ddddd", "fffff", "eeee", "a@aa.aa", "123456");

        // dodavanje arh listi
        arheolozi.Add(arh1);
            Console.WriteLine(arh1);
            Console.WriteLine(arheolozi);
            Console.ReadKey();
        }
        
    }
}
