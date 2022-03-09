using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2Primer
{
    enum Pozicija { GOLMAN, ODBRANA, SREDINA, NAPAD}

    class Fudbaler
    {
        int brojDresa;
        string ime;
        string prezime;
        DateTime datumRodjenja;
        Pozicija pozicijaFudbalera;

        public Fudbaler()
        {

        }

        public Fudbaler(int brojDresa, string ime, string prezime, DateTime datumRodjenja, Pozicija pozicijaFudbalera)
        {
            this.brojDresa = brojDresa;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.pozicijaFudbalera = pozicijaFudbalera;
        }

        public int BrojDresa { get => brojDresa; set => brojDresa = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public Pozicija PozicijaFudbalera { get => pozicijaFudbalera; set => pozicijaFudbalera = value; }
    }
}
