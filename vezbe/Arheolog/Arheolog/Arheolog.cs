using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arheolog
{
     public class Arheolog
    {
        //Polja
        string idArh;
        string ime;
        string prezime;
        string adresa;
        string grad;
        string drzava;
        string email;
        string brTel;

        List<string> gradovi;
        List<string> drzave;

        //Konstruktor bez parametara
        public Arheolog() : this("", "", "", "", "", "", "xxx@xx.xx", "")
        {

        }

        //Konstruktor sa parametrima
        public Arheolog(string idArh, string ime, string prezime, string adresa, string grad, string drzava, string email, string brTel)
        {
            this.IdArh = idArh;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.Grad = grad;
            this.Drzava = drzava;
            this.Email = email;
            this.BrTel = brTel;
            this.gradovi = new List<string>();
            this.drzave = new List<string>();            
        }

        //Getteri i Setteri
        public string IdArh { get => idArh; set => idArh = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Grad { get => grad; set => grad = value; }
        public string Drzava { get => drzava; set => drzava = value; }
        public string Email { get => email; set => email = value; }
        public string BrTel { get => brTel; set => brTel = value; }
        
        public List<string> Gradovi
        {
            get
            {
                List<string> list = new List<string>();
                foreach (string grd in gradovi)
                {
                    list.Add(grd);
                }
                return list;
            }
        }

        public List<string> Drzave
        {
            get
            {
                List<string> list = new List<string>();
                foreach (string grd in drzave)
                {
                    list.Add(grd);
                }
                return list;
            }
        }

        //Metode dodavanja u listu

        public void DodajGradListi(string grd)
        {
            if (!gradovi.Contains(grd))
            {
                gradovi.Add(grd);
                
            }           
        }

        public void DodajDrzavuListi(string drz)
        {
            if (!drzave.Contains(drz))
            {
                drzave.Add(drz);                
            }            
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", IdArh, Ime, Prezime, Adresa, Grad, Drzava, Email, BrTel);
        }
    }
}
