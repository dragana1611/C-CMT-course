using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2___Studenti
{
    public enum Smer { Racunarstvo, Menadzment, Geodezija, Gradjevina, Masinstvo, Matematika }
    public enum Pol { Musko, Zensko}
    public class Student
    {
        string ime;
        string prezime;
        int brIndeksa;
        DateTime datumRodjenja;
        int godinaStudiranja;
        Smer smer;
        Pol pol;
        List<Predmet> listaPredmeta;

        public Student() : this ("","",-1, new DateTime(),-1,Smer.Geodezija,Pol.Musko){ }
        public Student(string ime, string prezime, int brIndeksa, DateTime datumRodjenja, int godinaStudiranja, Smer smer, Pol pol)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.BrIndeksa = brIndeksa;
            this.DatumRodjenja = datumRodjenja;
            this.GodinaStudiranja = godinaStudiranja;
            this.Smer = smer;
            this.Pol = pol;
            this.listaPredmeta = new List<Predmet>();
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int BrIndeksa { get => brIndeksa; set => brIndeksa = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public int GodinaStudiranja { get => godinaStudiranja; set => godinaStudiranja = value; }
        public Smer Smer { get => smer; set => smer = value; }
        public Pol Pol { get => pol; set => pol = value; }
        
        public List<string> ListaPredmeta
        {
            get
            {
                List<string> list = new List<string>(); 
                foreach (Predmet predmet in listaPredmeta)
                {
                    list.Add(predmet.ToString());
                }
                return list;
            }
        }

        public void DodajStudentuPredmet(Predmet predmet)
        {
            listaPredmeta.Add(predmet);
        }
    }
}
