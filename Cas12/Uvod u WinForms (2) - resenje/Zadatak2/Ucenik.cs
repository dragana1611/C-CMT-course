using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    [Serializable]
    public class Ucenik
    {
        #region Properties
        string ime;
        string prezime;
        int razred;
        DateTime datumRodjenja;
        Skola skola;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public int Razred
        {
            get { return razred; }
            set { razred = value; }
        }

        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }

        public Skola Skola
        {
            get { return skola; }
            set { skola = value; }
        }

        #endregion Properties

        public Ucenik()
        { }
        public Ucenik(string ime, string prezime, int razred, DateTime datumRodjenja, Skola skola)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.razred = razred;
            this.datumRodjenja = datumRodjenja;
            this.skola = skola;
        }

        public override string ToString()
        {
            return "Ime:" + ime + ",Prezime:" + prezime 
                + ",Razred:" + razred + ",Datum rodjenja:"
                + datumRodjenja + ",Skola-" + skola.ToString();
        }
    }
}
