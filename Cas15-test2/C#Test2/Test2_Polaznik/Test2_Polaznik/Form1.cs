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

namespace Test2_Polaznik
{
    public partial class Form1 : Form
    {
        List<Polaznik> polaznici = new List<Polaznik>();

        public Form1()
        {
            InitializeComponent();
            InitComboBox();
            dataGridViewPolaznik.DataSource = polaznici.ToList();
        }


        private void InitComboBox()
        {
           
            for (int i = 7; i <= 77; i++)
            {
                cbGodine.Items.Add(i);
            }            
        }

        
        private bool DaLiJeSvePopunjeno()
        {
            bool retVal = true;

            if (tbIme.Text == "" || tbPrezime.Text == "" || cbSkola.Text == "" || cbGodine.SelectedIndex == -1)
            {
                retVal = false;
            }

            return retVal;
        }

        private bool DaLiJeRedSelektovan()
        {
            bool retVal = true;

            if (dataGridViewPolaznik.SelectedRows.Count == 0)
            {
                retVal = false;
            }

            return retVal;
        }

        private void OcistiPolja()
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            cbGodine.SelectedIndex = -1;
            cbSkola.Text = "";
            rbZensko.Checked = true;
            dataGridViewPolaznik.ClearSelection();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (DaLiJeSvePopunjeno())
            {
                Polaznik p = new Polaznik();
                
                p.Ime = tbIme.Text;
                p.Prezime = tbPrezime.Text;
                p.Godine = int.Parse(cbGodine.Text);
                p.Skola = cbSkola.Text;

                if (rbZensko.Checked)
                {
                    p.PolPolaznika = Pol.ZENSKO;
                }
                else if (rbMusko.Checked)
                {
                    p.PolPolaznika = Pol.MUSKO;
                }
                
                polaznici.Add(p);
                dataGridViewPolaznik.DataSource = polaznici.ToList();
               
                OcistiPolja();
            }
            else
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
        }


        private void dataGridViewPolaznik_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPolaznik.SelectedRows.Count > 0)
            {
                int indeks = dataGridViewPolaznik.SelectedRows[0].Index;

                cbGodine.SelectedItem = polaznici[indeks].Godine;
                tbIme.Text = polaznici[indeks].Ime;
                tbPrezime.Text = polaznici[indeks].Prezime;
                cbSkola.Text = polaznici[indeks].Skola;
                if (polaznici[indeks].PolPolaznika.Equals(Pol.ZENSKO))
                {
                    rbZensko.Checked = true;
                }
                else
                {
                    rbMusko.Checked = true;
                }

                toolStripStatusLabel1.Text = "Selektovan " + polaznici[indeks].Ime + " " + polaznici[indeks].Prezime;
            }
            else
            {
                toolStripStatusLabel1.Text = "Dobrodosli";
            }
        }


        private void izmeniPodatkeKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaLiJeSvePopunjeno())
            {
                if (DaLiJeRedSelektovan())
                {
                    int indeks = dataGridViewPolaznik.SelectedRows[0].Index;
                    polaznici[indeks].Godine = int.Parse(cbGodine.Text);
                    polaznici[indeks].Ime = tbIme.Text;
                    polaznici[indeks].Prezime = tbPrezime.Text;
                    polaznici[indeks].Skola = cbSkola.Text;
                    polaznici[indeks].PolPolaznika = rbZensko.Checked ? Pol.ZENSKO : Pol.MUSKO; ;

                    dataGridViewPolaznik.DataSource = polaznici.ToList();
                    OcistiPolja();
                }
                else
                {
                    MessageBox.Show("Red nije selektovan!");
                }
            }
            else
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
        }

        private void obrisiPolaznikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaLiJeRedSelektovan())
            {
                int indeks = dataGridViewPolaznik.SelectedRows[0].Index;
                polaznici.RemoveAt(indeks);

                dataGridViewPolaznik.DataSource = polaznici.ToList();
                
                OcistiPolja();
            }
            else
            {
                MessageBox.Show("Red nije selektovan!");
            }
        }

        private void vasaPorukaNastavnikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meni je ovo malo tesko, ali dajem sve od sebe da uradim sto vise, da se ne obrukam pred ovom decom koja kidaju ovo programiranje 🤦‍♀️ 😅");
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            cbSkola.Items.Add(textBoxNovaVrednost.Text);
            textBoxNovaVrednost.Text = "";
        }

        private void sacuvajPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder s = new StringBuilder();
                foreach (Polaznik p in polaznici)
                {
                    s.Append(p.Ime + " " + p.Prezime + "\n");
                }

                File.WriteAllText(saveFileDialog1.FileName, s.ToString());
            }
        }
    }
}
