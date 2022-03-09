using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak2
{
    public partial class Albumi : Form
    {
        Dictionary<string, Album> albumi = new Dictionary<string, Album>();
        public Albumi()
        {
            InitializeComponent();
            UcitajAlbume();
            UcitajComoBox();
        }

        public void UcitajComoBox()
        {
            foreach (string s in albumi.Keys)
            {
                comboBoxNazivAlbuma.Items.Add(s);
            }
        }

        public void UcitajAlbume()
        {
            string putanja = "Baza.txt";
            string[] linije = File.ReadAllLines(putanja, Encoding.UTF8);

            foreach (string linija in linije)
            {
                string[] podaciLinije = linija.Split('|');
                Album album = new Album();
                album.ImeAlbuma = podaciLinije[0];
                album.ImeIzvodjaca = podaciLinije[1];
                album.Datum = Convert.ToDateTime(podaciLinije[2]);
                album.NazivSlikeOmota = podaciLinije[3];
                string[] pesme = podaciLinije[4].Split(',');
                foreach (string pesma in pesme)
                {
                    album.DodajPesmuUListu(pesma);
                }
                albumi.Add(album.ImeAlbuma, album);
            }
        }

        private void comboBoxNazivAlbuma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nazivAlbuma = comboBoxNazivAlbuma.SelectedItem.ToString();
            Album album = albumi[nazivAlbuma];
            textBoxIzvodjac.Text = album.ImeIzvodjaca;
            textBoxDatum.Text = album.Datum.ToString();
            richTextBoxPesme.Text = album.ListaPesamaToString();
            pictureBoxSlikaOmota.Image = UcitajSliku(album.NazivSlikeOmota);
        }

        private Image UcitajSliku(string imeSlike)
        {
            Image img;
            try
            {
                img = Image.FromFile(imeSlike);
            }
            catch
            {
                img = Image.FromFile("nemaSlike.png");
            }
            return img;
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
