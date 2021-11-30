using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2___Instrumenti
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MuzickiInstrument> list = new List<MuzickiInstrument>(); //kolekcija - lista muzickih instrumenata

            Kontrabas kontrabas1 = new Kontrabas(VrstaInstrumenta.Zicani);
            Kontrabas kontrabas2 = new Kontrabas(VrstaInstrumenta.Zicani);
            Violina violina = new Violina(VrstaInstrumenta.Zicani);
            Saksofon saksofon1 = new Saksofon(VrstaInstrumenta.Duvacki);
            Saksofon saksofon2 = new Saksofon(VrstaInstrumenta.Duvacki);
            Saksofon saksofon3 = new Saksofon(VrstaInstrumenta.Duvacki);
            Frula frula = new Frula(VrstaInstrumenta.Duvacki);

            list.Add(kontrabas1);  //polimorfizam: ocekuje MuzickiInstrument, a saljemo Kontrabas
            list.Add(violina);     //polimorfizam: ocekuje MuzickiInstrument, a saljemo Violinu
            list.Add(kontrabas2);  //polimorfizam: ocekuje MuzickiInstrument, a saljemo Kontrabas
            list.Add(saksofon1);   //polimorfizam: ocekuje MuzickiInstrument, a saljemo Saksofon
            list.Add(saksofon2);   //polimorfizam: ocekuje MuzickiInstrument, a saljemo Saksofon
            list.Add(frula);       //polimorfizam: ocekuje MuzickiInstrument, a saljemo Frulu
            list.Add(saksofon3);   //polimorfizam: ocekuje MuzickiInstrument, a saljemo Saksofon

            foreach (MuzickiInstrument instrument in list)
            {
                Console.WriteLine(instrument.Sviraj()); //polimorfizam na delu
            }

            Console.ReadKey();
        }
    }
}
