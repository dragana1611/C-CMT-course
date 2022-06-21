using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arheolog
{
    public class Antikvitet
    {
        string id;
        string naziv;
        string datPronalaska;        
        string period;
        string tipAntikv;
        string lokalitet;
        string imgNaziv;
        List<Arheolog> arheolozi;
        int godOd;
        int godDo;

        public Antikvitet() : this("","", "", "", "", "", "")
        {}

        public Antikvitet( string id, string naziv, string datPronalaska, string period, string tipAntikv, string lokalitet, string imgNaziv)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.DatPronalaska = datPronalaska;
            this.Period = period;
            this.TipAntikv = tipAntikv;
            this.Lokalitet = lokalitet;
            this.ImgNaziv = imgNaziv;
            this.arheolozi = new List<Arheolog>();
            this.GodOd = godOd;
            this.GodDo = godDo;            
        }

        public string Id { get; set; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string DatPronalaska { get => datPronalaska; set => datPronalaska = value; }        
        public string Period { get => period; set => period = value; }
        public string TipAntikv { get => tipAntikv; set => tipAntikv = value; }
        public string Lokalitet { get => lokalitet; set => lokalitet = value; }
        public string ImgNaziv { get => imgNaziv; set => imgNaziv = value; }
        public List<Arheolog>Arheolozi { get => arheolozi; set => arheolozi = value; }
        public int GodOd { get => godOd; set => godOd = value == null  ? (-2000) : value; }
        public int GodDo { get => godDo; set => godDo = value == null ? DateTime.Now.Year : value; }
        
        
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", Id, Naziv, DatPronalaska, Period, TipAntikv, Lokalitet, ImgNaziv);
        }

        public string Prikaz
        {
            get { return this.ToString(); }
        }  
    }
}
