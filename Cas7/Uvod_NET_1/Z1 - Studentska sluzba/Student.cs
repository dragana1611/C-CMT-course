using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1___Studentska_sluzba
{
    public enum Smer { Programiranje, Masinstvo, Menadzment, Poljoprivreda, Pravo, Filozofija, Matematika, Fizika }
    class Student
    {
        string brIndeksa;
        string ime;
        string prezime;
        DateTime datumRodjenja;
        Smer smer;
        ArrayList listaPredmeta;

        public Student(string brIndeksa, string ime, string prezime, DateTime datumRodjenja, Smer smer)
        {
            this.brIndeksa = brIndeksa;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.smer = smer;
            this.listaPredmeta = new ArrayList();
        }

        public Student(string brIndeksa, string ime, string prezime, DateTime datumRodjenja, Smer smer, ArrayList listaPredmeta)
        {
            this.brIndeksa = brIndeksa;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.smer = smer;
            this.listaPredmeta = listaPredmeta;
        }

        public string BrIndeksa
        {
            get { return brIndeksa; }
            set { brIndeksa = value; }
        }
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
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }
        public Smer Smer
        {
            get { return smer; }
            set { smer = value; }
        }
        public ArrayList ListaPredmeta
        {
            get { return listaPredmeta; }
        }

        public bool DodajPredmet(string predmet)
        {
            if (!listaPredmeta.Contains(predmet))
            {
                listaPredmeta.Add(predmet);
                return true;
            }
            return false;
        }

        public bool ObrisiPredmet(string predmet)
        {
            if (listaPredmeta.Contains(predmet))
            {
                listaPredmeta.Remove(predmet);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ime i prezime : ");
            sb.Append(ime + " ");
            sb.Append(prezime);
            sb.AppendLine(" Datum rodjenja : " + datumRodjenja);
            sb.Append("Broj indeksa : " + brIndeksa);
            sb.AppendLine(" Smer: " + smer);
            sb.Append("Predmeti: ");
            for (int i = 0; i < listaPredmeta.Count; i++)
            {
                sb.Append((i + 1) + ". " + listaPredmeta[i] + " ");
            }

            return sb.ToString();
        }
    }
}
