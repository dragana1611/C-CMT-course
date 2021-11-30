using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1___Racun_u_banci
{
    class Program
    {
        static void Main(string[] args)
        {
            DevizniRacun devizniRacun = new DevizniRacun("123123123", "Jovan Jovic", 1000);
            DinarskiRacun dinarskiRacun = new DinarskiRacun("123456789", "Pera Peric", 5000, 1000);

            Console.WriteLine("Trenutno stanje na racunu je {0}", devizniRacun.SredstvaNaRacunu);
            devizniRacun.DodajPareNaRacun(200);
            Console.WriteLine("Trenutno stanje na racunu je {0}", devizniRacun.SredstvaNaRacunu);
            devizniRacun.SkiniPareSaRacuna(50);
            Console.WriteLine("Trenutno stanje na racunu je {0}", devizniRacun.SredstvaNaRacunu);


            Console.WriteLine("Trenutno stanje na racunu je {0}, dodajemo 50", dinarskiRacun.SredstvaNaRacunu);
            dinarskiRacun.DodajPareNaRacun(50);
            Console.WriteLine("Trenutno stanje na racunu je {0}, skidamo 5000", dinarskiRacun.SredstvaNaRacunu);
            dinarskiRacun.SkiniPareSaRacuna(5000);
            Console.WriteLine("Trenutno stanje na racunu je {0}, skidamo 500", dinarskiRacun.SredstvaNaRacunu);
            dinarskiRacun.SkiniPareSaRacuna(500);
            Console.WriteLine("Trenutno stanje na racunu je {0}, skidamo 5000", dinarskiRacun.SredstvaNaRacunu);
            dinarskiRacun.SkiniPareSaRacuna(5000);
            Console.WriteLine("Trenutno stanje na racunu je {0}", dinarskiRacun.SredstvaNaRacunu);


            Console.ReadKey();
        }
    }
}
