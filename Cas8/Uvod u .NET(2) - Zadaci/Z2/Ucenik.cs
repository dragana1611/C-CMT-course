using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    [Serializable]
    public class Ucenik
    {
        string ime;
        DateTime datumRodjenja;
        string skola;
        int razred;

        public Ucenik(string ime, DateTime datumRodjenja, string skola, int razred)
        {
            this.ime = ime;
            this.datumRodjenja = datumRodjenja;
            this.skola = skola;
            this.razred = razred;
        }

        public string Ime
        {
            get { return ime; }
        }

        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
        }

        public string Skola
        {
            get { return skola; }
        }

        public int Razred
        {
            get { return razred; }
        }

        public override string ToString()
        {
            return "\nIme : " + ime + "\nDatum Rodjenja : " + datumRodjenja + "\nSkola : " + skola + "\nRazred : " + razred;
        }

    }
}
