using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2___Instrumenti
{
    class Frula : MuzickiInstrument
    {
        public Frula(VrstaInstrumenta vrstaInstrumenta) : base(vrstaInstrumenta) { }

        public override string Sviraj()
        {
            return "Trenutno svira frula";
        }
    }
}
