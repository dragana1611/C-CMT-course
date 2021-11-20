using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2___Klase
{
    class Program
    {
        static void Main(string[] args)
        {
                RacionalanBroj r1 = new RacionalanBroj();       // Inicijalizovana pomoću konstruktora generisan od strane kompajlera
                RacionalanBroj r2 = new RacionalanBroj(2, 3);   // Inicijalizovana korisničkim definisanim konstruktorom

                // Inicijalizovana koristeći incijalizatora objekata (podrazumevani konstruktor će se pozvati)
                // Ako ne postoji dostupan podrazumevani konstruktor, inicijalizator objekata ne može da se koristi
                RacionalanBroj r3 = new RacionalanBroj
                {
                    Brojilac = 3,
                    Imenilac = 4
                };

                RacionalanBroj r4;                          // Neinicijalizovani objekat

            // Pristup i korišćenje neincijalizovanog objekta nije dozvoljeno
            //Console.WriteLine("r4 = {0}/{1}", r4.numerator, r4.denominator);
            r4 = new RacionalanBroj(1, 0);
                Console.WriteLine("r1 = {0}/{1}", r1.Brojilac, r1.Imenilac);
                Console.WriteLine("r2 = {0}/{1}", r2.Brojilac, r2.Imenilac);
                Console.WriteLine("r3 = {0}/{1}", r3.Brojilac, r3.Imenilac);
                Console.WriteLine("r4 = {0}/{1}", r4.Brojilac, r4.Imenilac);
            Console.WriteLine();
            }
        
    }
}
