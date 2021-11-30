using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1___Racun_u_banci
{
    public class DinarskiRacun : Racun
    {
        double dozvoljeniMinus;

        public DinarskiRacun(string brojRacuna, string imeKorisnika,
            double sredstvaNaRacunu, double dozvoljeniMinus = 0)
            : base(brojRacuna, imeKorisnika, sredstvaNaRacunu)
        {
            this.dozvoljeniMinus = dozvoljeniMinus;
        }

        public override bool SkiniPareSaRacuna(double suma)
        {
            if (SredstvaNaRacunu - suma >= 0 || Math.Abs(SredstvaNaRacunu - suma) <= dozvoljeniMinus)
            {
                SredstvaNaRacunu -= suma;
                return true;
            }

            return false;
        }
    }
}
