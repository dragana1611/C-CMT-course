using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Polaznik
{
    enum Pol { MUSKO, ZENSKO }
   
    class Polaznik
    {
        string ime;
        string prezime;
        int godine;
        string skola;
        Pol polPolaznika;

        public Polaznik() : this("", "", -1, "", Pol.ZENSKO) { }
        
        public Polaznik(string ime, string prezime, int godine, string skola, Pol polPolaznika)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godine = godine;
            this.skola = skola;
            this.polPolaznika = polPolaznika;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Godine { get => godine; set => godine = value; }
        public string Skola { get => skola; set => skola = value; }
        public Pol PolPolaznika { get => polPolaznika; set => polPolaznika = value; }
    }
}
