using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Srednjoskolac : Ucenik
    {
        public string smer;

        public Srednjoskolac(string ime, string prezime, string smer) : base(ime, prezime) { }

                                    

        public string Smer { get { return smer; } }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine(PredstaviSe() + $". Prosek mi je {Prosek()}. Srednjoskolac sam i idem na {Smer} smer");

            return sb.ToString();
        }


    }
}
