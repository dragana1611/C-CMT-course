using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1___Strukture
{

    // Deklaracija strukture
    struct Racionalan
    {
        public int brojilac; // = 0;	// Postavljanje vrednost članu podatka u deklaraciji strukture nije dozvoljeno
        public int imenilac;

        public Racionalan(int brojilac, int imenilac)
        {
            this.brojilac = brojilac;
            this.imenilac = imenilac;
        }
        
        // Podrazumevani konstruktor nije dozvoljen u strukturi
        //public Racionalan() {}
        
        // Svako polje se mora eksplicitno inicijalizovati u konstruktoru
        //public Racionalan(int brojilac)
        //{
        //    this.brojilac = brojilac;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Racionalan r1 = new Racionalan();		// Inicijalizovana pomoću konstruktora generisan od strane kompajlera
            Racionalan r2 = new Racionalan(1, 2);	// Inicijalizovana korisničkim definisanim konstruktorom

            // Inicijalizovana koristeći incijalizatora objekata (podrazumevani konstruktor će se pozvati)
            Racionalan r3 = new Racionalan
            {
                brojilac = 2,
                imenilac = 3
            };

            Racionalan r4;                              // Neinicijalizovani objekat

            // Pristup i korišćenje neincijalizovanog objekta nije dozvoljeno
            //Console.WriteLine("r4 = {0}/{1}", r4.brojilac, r4.imenilac);

            // Dodeljivanje vrednosti članovima objekta
            r4.brojilac = 3;
            r4.imenilac = 4;

            Console.WriteLine("r1 = {0}/{1}", r1.brojilac, r1.imenilac);
            Console.WriteLine("r2 = {0}/{1}", r2.brojilac, r2.imenilac);
            Console.WriteLine("r3 = {0}/{1}", r3.brojilac, r3.imenilac);
            Console.WriteLine("r4 = {0}/{1}", r4.brojilac, r4.imenilac);

            Console.WriteLine();
        }
    }
}
