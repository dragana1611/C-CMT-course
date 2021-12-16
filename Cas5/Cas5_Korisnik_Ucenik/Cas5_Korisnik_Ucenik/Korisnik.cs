using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas5_Korisnik_Ucenik
{
    class Korisnik
    {
        string ime, prezime;
        public Korisnik()
        {
            Ime = "Pera";
            Prezime = "Peric";
        }

        public Korisnik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public virtual void PredstaviSe()
        {
            Console.WriteLine($"Zovem se {Ime} {Prezime}.");
        }
    }
}
