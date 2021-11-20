using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1___Koordinatne_tacke
{
    public struct KoordinatnaTacka
    {
        //moze da sadrzi i svojstva (get i set)
        int x;
        int y;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        // moze da sadrzi samo konstruktor sa parametrima i to da obuhvata sva polja koja se nalaze u strukturi
        public KoordinatnaTacka(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //moze da sadrzi metode kao i klasa

        public override string ToString()
        {
            return String.Format("({0},{1})", x, y);
        }
    }
}
