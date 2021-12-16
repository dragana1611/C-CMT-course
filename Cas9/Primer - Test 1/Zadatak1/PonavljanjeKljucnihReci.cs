using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public enum NacinSortiranja { Rastuce, Opadajuce }

    class PonavljanjeKljucnihReci : KljucnaRec
    {
        
        public PonavljanjeKljucnihReci(string putanja, int granica) : base(putanja, granica)
        {
        }

        public void EksportPonavljanja(string putanja, NacinSortiranja nacinSortiranja)
        {
            string sadrzaj = "NEMA KLJUCNIH RECI.";

            if (reci.Count > 0) //key/value pairs contaned in the Dictionary<>
            {
                StringBuilder sb = new StringBuilder();
                string najcescaRec = NajcescaRec();
                int brojPonavljanjaNajcesceReci = reci[najcescaRec];
                

                if (nacinSortiranja.Equals(NacinSortiranja.Opadajuce))
                {                    
                    for (int i = brojPonavljanjaNajcesceReci; i >= 0; i--)
                    {
                        string value = "";
                        foreach (KeyValuePair<string, int> kvp in reci)
                        {
                            if (kvp.Value == i)
                            {
                                if (value != "")
                                {
                                    value += ", " + kvp.Key;
                                }
                                else
                                {
                                    value += kvp.Key;
                                }
                                
                            }
                        }
                        if (value != "")
                            sb.AppendLine(i + " - " + value);
                    }
                }
                else
                {
                    for (int i = 0; i <= brojPonavljanjaNajcesceReci; i++)
                    {
                        string value = "";
                        foreach (KeyValuePair<string, int> kvp in reci)
                        {

                            if (kvp.Value == i)
                            {
                                if (value != "")
                                {
                                    value += ", " + kvp.Key;
                                }
                                else
                                {
                                    value += kvp.Key;
                                }

                            }
                        }
                        if (value != "")
                            sb.AppendLine(i + " - " + value);
                    }
                }
                sadrzaj = sb.ToString();
            }

            Metode.UpisUFajl(putanja, sadrzaj);
        }

    }
}
