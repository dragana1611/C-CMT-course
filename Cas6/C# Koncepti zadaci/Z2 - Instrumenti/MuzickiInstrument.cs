using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2___Instrumenti
{
    public enum VrstaInstrumenta { Zicani, Duvacki }
    abstract class MuzickiInstrument
    {
        private VrstaInstrumenta vrstaInstrumenta;

        public VrstaInstrumenta VrstaInstrumenta
        { 
            get { return vrstaInstrumenta; }
            set { vrstaInstrumenta = value; }
        }

        public MuzickiInstrument(VrstaInstrumenta vrstaInstrumenta)
        {
            VrstaInstrumenta = vrstaInstrumenta;
        }

        public abstract string Sviraj();
    }
}
