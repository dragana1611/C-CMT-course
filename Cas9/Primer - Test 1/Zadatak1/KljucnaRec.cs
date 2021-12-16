using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class KljucnaRec : IRec
    {
        // string je rec, int je broj ponavljanja
        public Dictionary<string, int> reci = new Dictionary<string, int>();

        public KljucnaRec(string putanja, int granica)
        {
            Dictionary<string, int> reciTemp = new Dictionary<string, int>();
            // pronalazimo kljucnu rec iz zadatog fajla
            // kljucna rec je ako se ponavlja vise puta od zadate granice
            string tekst = Metode.CitanjeIzFajla(putanja);
            string[] reciIzFajla = tekst.Split(new char[] {' ', '.', ',', '!','?','\n', '\t', '\r'});
            // izbrojimo sve reci koje postoje u fajlu
            foreach (string s in reciIzFajla)
            {
                if (string.IsNullOrWhiteSpace(s))
                    continue;
                string key = s.ToUpper();
                if (reciTemp.ContainsKey(key))
                    reciTemp[key]++;
                else
                    reciTemp[key] = 1;
            }
            // izaberemo kljucne reci na osnovu zadatog kriterijuma
            foreach (KeyValuePair<string, int> kvp in reciTemp)
            {
                if (kvp.Value > granica)
                    reci.Add(kvp.Key, kvp.Value);
            }

        }

        public string NajcescaRec()
        {
            string najcescaRec = "";
            int brojPonavljanja = 0;

            foreach (KeyValuePair<string, int> kvp in reci)
            {
                if (brojPonavljanja < kvp.Value)
                {
                    brojPonavljanja = kvp.Value;
                    najcescaRec = kvp.Key;
                }
            }
            return najcescaRec;
        }

        public int NajduzaRec()
        {
            // pronalazimo najduzu kljucnu rec u recniku
            int duzina = 0;

            foreach (string rec in reci.Keys)
            {
                if (rec.Length > duzina)
                    
                    duzina = rec.Length;
            }
            return duzina;
        }

        public string NajduzaRecRec()
        {
            string najduzaRec = "";
            int duzina = 0;
            foreach (string rec in reci.Keys)
            {
                if (rec.Length > duzina)
                {
                    duzina = rec.Length;
                    najduzaRec = rec;
                }
                
            }
            return najduzaRec;            
        }

        public void EksportKljucneReci(string putanja)
        {
            string sadrzaj = "NEMA KLJUCNIH RECI.";

            if(reci.Count > 0)
                sadrzaj = ToString();

            Metode.UpisUFajl(putanja, sadrzaj);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, int> kvp in reci)
            {
                //sb.AppendLine(kvp.Key + " - " + kvp.Value);
                sb.AppendLine($"{kvp.Key} - {kvp.Value}");
            }

            return sb.ToString();
        }
    }
}
