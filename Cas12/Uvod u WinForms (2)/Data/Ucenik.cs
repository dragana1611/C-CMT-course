using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Razred { get; set; }

        public Ucenik(string ime, string prezime, int razred)
        {
            Ime = ime;
            Prezime = prezime;
            Razred = razred;
        }
    }
}
