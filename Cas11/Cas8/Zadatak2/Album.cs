using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Album
    {
        string imeAlbuma;
        string imeIzvodjaca;
        DateTime datum;
        List<String> listaPesama = new List<string>();
        string nazivSlikeOmota;

        public Album() : this("", "", DateTime.Now, "")
        {
        }

        public Album(string imeAlbuma, string imeIzvodjaca, DateTime datum, string nazivSlikeOmota)
        {
            this.imeIzvodjaca = imeIzvodjaca;
            this.imeAlbuma = imeAlbuma;
            this.datum = datum;
            this.nazivSlikeOmota = nazivSlikeOmota;
        }
        public string ImeAlbuma { get => imeAlbuma; set => imeAlbuma = value; }
        public string ImeIzvodjaca { get => imeIzvodjaca; set => imeIzvodjaca = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public List<string> ListaPesama { get => listaPesama; set => listaPesama = value; }
        public string NazivSlikeOmota { get => nazivSlikeOmota; set => nazivSlikeOmota = value; }

        public string ListaPesamaToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in listaPesama)
            {
                sb.AppendLine(s);
            }
            return sb.ToString();
        }

        public void DodajPesmuUListu(string pesma)
        {
            listaPesama.Add(pesma);
        }
    }
}
