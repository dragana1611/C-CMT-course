using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas5_Korisnik_Ucenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u = new Ucenik();
            u.PredstaviSe();
            u.Umanji(50);
            
           // u.Prezime = "Ivic";
           // u.Prosek = 10;
           // u.PredstaviSe();
          //  u.IspisInicijala();

          //  Console.WriteLine(Math.PI);
            
                
                
            Ucenik u2 = new Ucenik("Vuk", "Vucic", 1);
            u2.PredstaviSe();
            u2.Umanji(200);
           // Korisnik k = new Korisnik("Ana", "Anic");
           // k.PredstaviSe();
            // k.IspisInicijala();

            Ucenik u3 = new Ucenik("A", "B", 4);
            
            u3.Umanji(500);
            u3.PredstaviSe();

            u.PredstaviSe();

            Ucenik.novac = 10000000;

            u.PredstaviSe();

            Console.ReadKey();
        }
    }
}
