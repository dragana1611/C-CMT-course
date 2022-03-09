using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2___Studenti
{
    public class Predmet
    {
        static int count = 0;
        public Predmet(string nazivPredmeta, string profesor, int godina)
        {
            this.nazivPredmeta = nazivPredmeta;
            this.profesor = profesor;
            this.godina = godina;
            count++;
            IdPredmeta = count;
        }

        public Predmet() : this("","",-1) { }

        int idPredmeta;
        string nazivPredmeta;
        string profesor;
        int godina;

        public string NazivPredmeta { get => nazivPredmeta; set => nazivPredmeta = value; }
        public string Profesor { get => profesor; set => profesor = value; }
        public int Godina { get => godina; set => godina = value; }
        public int IdPredmeta { get => idPredmeta; set => idPredmeta = value; }

        public override string ToString()
        {
            return String.Format("{0} : {1} - {2} ({3} godina) ", 
                IdPredmeta, NazivPredmeta, Profesor, Godina);
        }
    }
}
