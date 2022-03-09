using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_21_22
{
    class Ucenik : ISvedocanstvo
    {
        Dictionary<string, int> finalneOcene;
        string ime;
        string prezime;

        public Ucenik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.finalneOcene = new Dictionary<string, int>();
        }

        public string Ime { get => ime; }
        public string Prezime { get => prezime; }
        public Dictionary<string, int> FinalneOcene { get => finalneOcene; }

        public string PredstaviSe()
        {
            return "Zovem se " + Ime + " " + Prezime + ".";
        }

        public double Prosek()
        {
            int suma = 0;

            foreach (int fo in FinalneOcene.Values)
                suma += fo;

            return (suma == 0) ? 0 : suma / (double)FinalneOcene.Count;
        }

        virtual public void UcitajOcene()
        {
            string naziv, kraj;
            int ocena;

            do
            {
                Console.WriteLine("Unesi naziv predmeta: ");
                naziv = Console.ReadLine();

                Console.WriteLine("Unesi ocenu: ");
                ocena = Convert.ToInt32(Console.ReadLine());

                FinalneOcene.Add(naziv, ocena);

                Console.WriteLine("Kraj unosa (unesite DA za kraj)?");
                kraj = Console.ReadLine();
            }
            while (kraj != "DA");
        }

        public override string ToString()
        {
            return PredstaviSe() + " Prosek mi je " + Prosek() + ".";
        }
    }
}
