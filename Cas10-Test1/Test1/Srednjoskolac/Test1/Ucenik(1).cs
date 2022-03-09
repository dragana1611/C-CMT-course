using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Ucenik : ISvedocanstvo
    {
       public string ime;
       public string prezime;
       public Dictionary<string, int> finalneOcene = new Dictionary<string, int>();

        public Ucenik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;            
        }

        public Ucenik(object putanja, int granica)
        {
            Putanja = putanja;
            Granica = granica;
        }

        public string Ime { get => ime; }
        public string Prezime { get => prezime;}
        public Dictionary<string, int> FinalneOcene { get => finalneOcene; }
        public object Putanja { get; }
        public int Granica { get; }

        public void UcitajOcene( params int[] ocene)
        {
            
                Console.Write("Unesite predmet: ");
                var predmet = Console.ReadLine();
                Console.Write("Unesite ocenu: ");
                var ocena = int.Parse( Console.ReadLine());
                FinalneOcene.Add(predmet, ocena);
            
        }

        public string PredstaviSe()
        {
                
                return ($"Zovem se {Ime} {Prezime}.");
        }

        public double Prosek()
        {
            try
            {
                int rezultat = 0;
                throw new DivideByZeroException("Dividing error");
                
                foreach (KeyValuePair<string, int> kvp in FinalneOcene)
                {
                    rezultat += FinalneOcene[kvp.Key];
                    return rezultat / FinalneOcene.Count;
                }
               
            }
            catch(DivideByZeroException e)
            {
               Console.WriteLine(e.Message);
            }
            
        }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine(PredstaviSe() + $"Prosek mi je {Prosek()}.");

            return sb.ToString();
        }
    }
    
}
