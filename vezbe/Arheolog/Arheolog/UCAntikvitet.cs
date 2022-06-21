using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arheolog
{
    public partial class UCAntikvitet : UserControl
    {
        List<Arheolog> arheolozi = new List<Arheolog>();
        public static List<Antikvitet> antikviteti = new List<Antikvitet>();
        
        //povezivanje liste
        BindingSource antikvitetiBindingSource = new BindingSource();
        
        public UCAntikvitet()
        {
            InitializeComponent();
        }
                

        private void UCAntikvitet_Load(object sender, EventArgs e)
        {
            lbAntikvitet.DisplayMember = "Prikaz";            
            lbAntikvitet.DataSource = UcitajAntikvitete();            
            lbAntikvitet.SelectedIndex = -1;            
        }

        //inicijalizacija

        public List<Antikvitet> UcitajAntikvitete()
        {
            string putanja = "Antikvitet.txt";
            StreamReader sr = new StreamReader(putanja);
            while (!sr.EndOfStream) 
            { 
                try
                {                
                    string line = sr.ReadLine();
                
                        string[] podaci = line.Split('|');
                        Antikvitet ant = new Antikvitet();
                        ant.Id = podaci[0];
                        ant.Naziv = podaci[1];
                        ant.DatPronalaska = podaci[2];
                        ant.Period = podaci[3];
                        ant.TipAntikv = podaci[4];
                        ant.Lokalitet = podaci[5];
                        ant.ImgNaziv = podaci[6];

                    antikviteti.Add(ant);
                
                }
                catch (Exception ex)
                {
                    throw;
                    MessageBox.Show("Doslo je do problema sa ucitavanjem txt fajla!", ex.Message);
                }
            }
            sr.Close();
            return antikviteti;
        }

        public void receiveData(string newId,string newNaziv, string newDatPronalaska, string newPeriod, string newTipAntikviteta, string newLokalitet, string newImgName)
        {
            
            Antikvitet a = new Antikvitet(newId, newNaziv, newDatPronalaska, newPeriod, newTipAntikviteta, newLokalitet, newImgName);

            antikviteti.Add(a);

            StreamWriter sw = new StreamWriter("Izmena.txt");
            foreach (Antikvitet x in antikviteti)
            {
                sw.WriteLine(x.ToString());
            }
            sw.Close();
            lbAntikvitet.DisplayMember = "Prikaz";
            lbAntikvitet.DataSource = null;

            lbAntikvitet.DataSource = antikviteti;
        }

        //UCAntikvitet otvara mini formu za dodavanje antikviteta klikom na dugme dDodavanje
        public void btnDodavanjeUC_Click(object sender, EventArgs e)
        {            
                Dodaj_Antikvitet fda = new Dodaj_Antikvitet();
                fda.ShowDialog();
        }

        public void UCAntikvitet_Activated(object sender, EventArgs e)
        {
            lbAntikvitet.DisplayMember = "Prikaz";
            lbAntikvitet.DataSource = null;

            lbAntikvitet.DataSource = antikviteti;

        }

        //provera da li je red u listbox-u selektovan
        public bool DaLiJeRedSelektovan()
        {
            bool retVal = true;

            if (lbAntikvitet.SelectedItems.Count == 0)
            {
                retVal = false;
            }
            return retVal;
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            if (DaLiJeRedSelektovan())
            {
                int indx = lbAntikvitet.SelectedIndex;
                if(indx >= 0)
                {
                    DialogResult izlaz = MessageBox.Show("Da li ste sigurni da zelite da izbrisete selektovani red?", "Brisanje", MessageBoxButtons.YesNo);
                    if (izlaz == DialogResult.Yes)
                    {
                        antikviteti.RemoveAt(indx);
                        lbAntikvitet.DisplayMember = "Prikaz";
                        lbAntikvitet.DataSource = null;

                        lbAntikvitet.DataSource = antikviteti;
                        MessageBox.Show("Uspesno brisanje!");
                    } 
                    
                }
            }
        }

        public void deleteData(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            if (DaLiJeRedSelektovan())
            {
                int indx = lbAntikvitet.SelectedIndex;
                if (indx >= 0)
                {
                    DialogResult izlaz = MessageBox.Show("Da li ste sigurni da zelite da izbrisete selektovani red?", "Brisanje", MessageBoxButtons.YesNo);
                    if (izlaz == DialogResult.Yes)
                    {
                        antikviteti.RemoveAt(indx);
                        lbAntikvitet.DisplayMember = "Prikaz";
                        lbAntikvitet.DataSource = null;

                        lbAntikvitet.DataSource = antikviteti;
                        MessageBox.Show("Uspesno brisanje!");
                    }

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbAntikvitet.BeginUpdate();

            lbAntikvitet.DataSource = antikviteti;

            lbAntikvitet.EndUpdate();
        }
    }
}
