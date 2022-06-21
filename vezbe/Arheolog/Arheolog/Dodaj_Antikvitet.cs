using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arheolog
{
    public partial class Dodaj_Antikvitet : Form
    {
        public Dodaj_Antikvitet()
        {
            InitializeComponent();            
        }
        List<Antikvitet> antikviteti = new List<Antikvitet>();        

        //provera da li su sva polja popunjena
        public bool DaLiJeSvePopunjeno()
        {
            bool retVal = true;

            if (tbNaziv.Text == "" || tbDatPronal.Text == "" || tbPeriod.Text == "" || tbTipAntikv.Text == "" || tbLokalitet.Text == "" || tbImgNaziv.Text == "")
            {
                retVal = false;
            }

            return retVal;
        }

        //reset polja
        public void OcistiPolja()
        {
            tbNaziv.Text = "";
            tbDatPronal.Text = "";
            tbPeriod.Text = "";
            tbTipAntikv.Text = "";
            tbLokalitet.Text = "";
            tbImgNaziv.Text = "";
        }

        public void btnDodavanjeUC_Click(object sender, EventArgs e)
        {
            UCAntikvitet uca = new UCAntikvitet();
            uca.receiveData(tbPrikazAnt.Text, tbNaziv.Text, tbDatPronal.Text, tbPeriod.Text, tbTipAntikv.Text, tbLokalitet.Text, tbImgNaziv.Text);
            
            if (DaLiJeSvePopunjeno())
            {
                Antikvitet a = new Antikvitet();
                a.Id = tbPrikazAnt.Text;
                a.Naziv = tbNaziv.Text;
                a.DatPronalaska = tbDatPronal.Text;
                a.Period = tbPeriod.Text;
                a.TipAntikv = tbTipAntikv.Text;
                a.Lokalitet = tbLokalitet.Text;
                a.ImgNaziv = tbImgNaziv.Text;

                antikviteti.Add(a);
                MessageBox.Show("Uspesno ste dodali antikvitet");
                OcistiPolja();
            }
            else
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }            
        }

        private void btnBrisanjeAntikviteta_Click(object sender, EventArgs e)
        {
            UCAntikvitet uca = new UCAntikvitet();
            uca.deleteData(tbNaziv.Text, tbDatPronal.Text, tbPeriod.Text, tbTipAntikv.Text, tbLokalitet.Text, tbImgNaziv.Text);
            Antikvitet a = new Antikvitet();
            a.Naziv = tbNaziv.Text;
            a.DatPronalaska = tbDatPronal.Text;
            a.Period = tbPeriod.Text;
            a.TipAntikv = tbTipAntikv.Text;
            a.Lokalitet = tbLokalitet.Text;
            a.ImgNaziv = tbImgNaziv.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            OcistiPolja();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }
        /*pictureBoxSlikaOmota.Image = UcitajSliku(album.NazivSlikeOmota);
        }*/

        private Image UcitajSliku(string ImgNaziv)
        {
            Image img;
            try
            {
                img = Image.FromFile(ImgNaziv);
            }
            catch
            {
                img = Image.FromFile("nemaSlike.png");
            }
            return img;
        
        } 
    }
}
