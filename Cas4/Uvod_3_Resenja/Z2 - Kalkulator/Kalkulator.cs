using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2___Kalkulator
{
    public class Kalkulator
    {
        public int Saberi(params int[] brojevi)
        {
            int rezultat = 0;
            foreach (int broj in brojevi)
            {
                rezultat += broj;
            }
            return rezultat;
        }
        public void Oduzmi(out int rezultat, params int[] brojevi)
        {
            rezultat = 0;
            foreach (int broj in brojevi)
            {
                rezultat -= broj;
            }
        }

        public int Pomnozi(int broj1, int broj2)
        {
            return broj1 * broj2;
        }

        public double Podeli(int broj1, int broj2)
        {
            return (double)broj1 / broj2;
        }

        public void Uvecaj(ref int broj, int uvecajZa)
        {
            broj += uvecajZa;
        }

    }
}
