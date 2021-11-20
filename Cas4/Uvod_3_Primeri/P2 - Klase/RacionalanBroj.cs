using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2___Klase
{
    // Deklaracija klase
    class RacionalanBroj
    {
        int brojilac;	//po default-u je privat
        int imenilac;

        public int Brojilac // isto ima kao polje samo sa velikim slovom
        {
            get { return brojilac; }
            set { brojilac = value; }
        }

        public int Imenilac
        {
            get { return imenilac; }
            set { imenilac = (value == 0) ? 1 : value; }
        }

        // Podrazumevani konstruktor je eksplicitno definisan, pošto će bilo koji korisnički definisan konstruktor
        // sprečiti kompajlera da automatski generiše podrazumevani.
        // Podrazumevani konstruktor je ovde definisani radi demonstracije. Treba ga izostaviti s obzirom da 
        // racionalan broj nema validnu podrazumevanu vrednost koja ima smisla (osim možda nedefinisanu vrednost)
        public RacionalanBroj() // konstruktor bez parametara
        {
        }


        public RacionalanBroj(int brojilac, int imenilac)// konstruktor sa parametrima
        {
            this.brojilac = brojilac;
            this.imenilac = imenilac;
        }


        
    }
}
