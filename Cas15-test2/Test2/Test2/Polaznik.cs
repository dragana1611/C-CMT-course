using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    enum Pol { MUSKO, ZENSKO }
    class Polaznik
    {
        string ime;
        string prezime;
        Pol pol;
        int godine;
        string skola;

        public Polaznik()
        {
        }

        public Polaznik(string ime, string prezime, Pol pol, int godine, string skola)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.pol = pol;
            this.godine = godine;
            this.skola = skola;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Godine { get => godine; set => godine = value; }
        public string Skola { get => skola; set => skola = value; }
        public Pol Pol { get => pol; set => pol = value; }
    }
}
