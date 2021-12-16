using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas5_Korisnik_Ucenik
{
    class Ucenik : Korisnik
    {
        double prosek;
        public static double novac=1000;

        public Ucenik() : base("Mara", "Maric")
        {
            Prosek = 4.85;
        }


        public void Umanji(int iznos)
        {
            novac -= iznos;
        }

        public Ucenik(double p)
        {
            Prosek = p;
        }


        public Ucenik(string i, string p, double pr) : base(i, p)
        {
            Prosek = pr;
        }

        public override void PredstaviSe()
        {
            base.PredstaviSe();
            Console.WriteLine($"Prosek mi je {Prosek}.");
            Console.WriteLine($"Imamo {novac} dinara. \n");
        }


        public void IspisInicijala()

        {
            base.PredstaviSe();
            Console.WriteLine($"{Ime[0]}{Prezime[0]} ");
        }


        public double Prosek { get => prosek; set => prosek = (value < 1 || value > 5) ? 5 : value; }
    }
}
