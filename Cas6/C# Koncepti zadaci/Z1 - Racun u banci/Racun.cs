using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1___Racun_u_banci
{
    public class Racun
    {
        string brojRacuna;
        string imeKorisnika;
        double sredstvaNaRacunu;

        public string BrojRauna
        {
            get { return brojRacuna; }
        }

        public string ImeKorisnika
        {
            get { return imeKorisnika; }
        }

        public double SredstvaNaRacunu
        {
            get { return sredstvaNaRacunu; }
            protected set { sredstvaNaRacunu = value; }
        }

        public Racun(string brojRacuna, string imeKorisnika, double sredstvaNaRacunu)
        {
            this.brojRacuna = brojRacuna;
            this.imeKorisnika = imeKorisnika;
            this.sredstvaNaRacunu = sredstvaNaRacunu;
        }

        public virtual void DodajPareNaRacun(double suma)
        {
            SredstvaNaRacunu += suma;
        }

        public virtual bool SkiniPareSaRacuna(double suma)
        {
            if (SredstvaNaRacunu >= suma)
            {
                SredstvaNaRacunu -= suma;
                return true;
            }
            return false;
        }
    }
}
