using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1__Restorani
{
    public enum Tip { domaci, strani }
    public class Restoran
    {
        string naziv;
        string adresa;
        bool daLiJeOtvoren;
        string specijalitet;
        Tip tipRestorana;

        public string Naziv { get => naziv; set => naziv = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public bool DaLiJeOtvoren { get => daLiJeOtvoren; set => daLiJeOtvoren = value; }
        public string Specijalitet { get => specijalitet; set => specijalitet = value; }
        public Tip TipRestorana { get => tipRestorana; set => tipRestorana = value; }

        public Restoran(string naziv, string adresa, bool daLiJeOtvoren, string specijalitet, Tip tipRestorana)
        {
            this.naziv = naziv;
            this.adresa = adresa;
            this.daLiJeOtvoren = daLiJeOtvoren;
            this.specijalitet = specijalitet;
            this.tipRestorana = tipRestorana;
        }

        public Restoran() { }
    }
}
