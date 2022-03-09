using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_21_22
{
    class Srednjoskolac : Ucenik
    {
        string smer;

        public string Smer { get => smer; }

        public Srednjoskolac(string ime, string prezime, string smer) : base(ime, prezime)
        {
            this.smer = smer;
        }

        public override void UcitajOcene()
        {
            string sadrzaj = "";

            byte[] bafer;

            try
            {
                using (FileStream fajlStream = new FileStream("srednjoskolac_ocene.txt", FileMode.Open, FileAccess.Read))
                {
                    int length = (int)fajlStream.Length;
                    bafer = new byte[length];
                    fajlStream.Read(bafer, 0, length);
                }

                sadrzaj = Encoding.UTF8.GetString(bafer);
            }
            catch
            {
                Console.WriteLine("GRESKA: Problem sa ucitavanjem podataka iz fajla!");
            }

            if (sadrzaj != "")
            {
                string[] vrednosti = sadrzaj.Split(',');

                for (int i = 0; i < vrednosti.Length; i += 2)
                {
                    FinalneOcene.Add(vrednosti[i], Convert.ToInt32(vrednosti[i + 1]));
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Srednjoskolac sam i idem na " + Smer + " smer.";
        }
    }
}
