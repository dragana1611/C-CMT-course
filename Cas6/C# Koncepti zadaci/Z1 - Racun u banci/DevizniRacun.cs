using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1___Racun_u_banci
{
    public class DevizniRacun : Racun
    {
        const double kamataDodavanje = 0.025;
        const double kamataSkidanje = 0.05;
        public DevizniRacun(string brojRacuna, string imeKorisnika, double sredstvaNaRacunu)
            : base(brojRacuna, imeKorisnika, sredstvaNaRacunu)
        { 
        }

        public override void DodajPareNaRacun(double suma)
        {
            base.DodajPareNaRacun(suma - suma * kamataDodavanje);
        }

        public override bool SkiniPareSaRacuna(double suma)
        {
            return base.SkiniPareSaRacuna(suma + suma * kamataSkidanje);
        }

    }
}
