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
        int brojilac;	
        int imenilac;

        public int Brojilac
        {
            get { return brojilac; }
            set { brojilac = value; }
        }

        public int Imenilac
        {
            get { return imenilac; }
            set { imenilac = value; }
        }

        // Podrazumevani konstruktor je eksplicitno definisan, pošto će bilo koji korisnički definisan konstruktor
        // sprečiti kompajlera da automatski generiše podrazumevani.
        // Podrazumevani konstruktor je ovde definisani radi demonstracije. Treba ga izostaviti s obzirom da 
        // racionalan broj nema validnu podrazumevanu vrednost koja ima smisla (osim možda nedefinisanu vrednost)
        public RacionalanBroj()
        {
        }


        public RacionalanBroj(int brojilac, int imenilac)
        {
            this.brojilac = brojilac;
            this.imenilac = imenilac;
        }


        
    }
}
