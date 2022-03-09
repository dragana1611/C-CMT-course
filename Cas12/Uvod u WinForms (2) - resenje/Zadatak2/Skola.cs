using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    [Serializable]
    public class Skola
    {
        private string imeSkole;
        private string adresa;
        private string grad;

        public string ImeSkole
        {
            get { return imeSkole; }
            set {  imeSkole = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set {  adresa = value; }
        }

        public string Grad
        {
            get { return grad; }
            set {  grad = value; }
        }
        public Skola():this("","","")
        {
        }
            public Skola(string ime, string adresa, string grad)
        {
            imeSkole = ime;
            this.adresa = adresa;
            this.grad = grad;
            
        }

        public override string ToString()
        {
            return "Skola:" + imeSkole + ",Grad:" + grad + ",Adresa:" + adresa;
        }
    }
}
