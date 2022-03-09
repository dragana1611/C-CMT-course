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

namespace Test2
{
    public partial class Form1 : Form
    {
        List<Polaznik> polaznici = new List<Polaznik>();

        public Form1()
        {
            InitializeComponent();
            PopuniPodatke();
            dgwPodaci.DataSource = polaznici.ToList();
        }

        private void PopuniPodatke()
        {
            for (int i = 7; i <= 77; i++)
                cbGodine.Items.Add(i);

            /*
            string[] skole = { "Jovina gimnazija", "ETS", "Masinska skola" };
            for (int i = 0; i < skole.Length; i++)
                cbSkola.Items.Add(skole[i]);

            polaznici.Add(new Polaznik("Marko", "Markovic", Pol.MUSKO, 18, skole[0]));
            polaznici.Add(new Polaznik("Petar", "Petrovic", Pol.MUSKO, 16, skole[2]));
            polaznici.Add(new Polaznik("Iva", "Ivic", Pol.ZENSKO, 17, skole[2]));
            polaznici.Add(new Polaznik("Ivana", "Ivanovic", Pol.ZENSKO, 18, skole[1]));
            */
        }

        private bool DaLiJeSvePopunjeno()
        {
            bool retVal = true;

            if (tbIme.Text == "" || tbPrezime.Text == "" || cbGodine.SelectedIndex == -1 || cbSkola.Text == "")
            {
                retVal = false;
            }

            return retVal;
        }

        private bool DaLiJeRedSelektovan()
        {
            bool retVal = true;

            if (dgwPodaci.SelectedRows.Count == 0)
            {
                retVal = false;
            }

            return retVal;
        }

        private void OcistiPolja()
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            rbZensko.Checked = true;
            cbGodine.SelectedIndex = -1;
            cbSkola.Text = "";
            dgwPodaci.ClearSelection();
        }

        private void btnComboBoxVrednost_Click(object sender, EventArgs e)
        {
            cbSkola.Items.Add(tbComboBoxVrednost.Text);
            tbComboBoxVrednost.Text = "";
        }

        private void dgwPodaci_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwPodaci.SelectedRows.Count > 0)
            {
                int indeks = dgwPodaci.SelectedRows[0].Index;
                tbIme.Text = polaznici[indeks].Ime;
                tbPrezime.Text = polaznici[indeks].Prezime;
                if (polaznici[indeks].Pol.Equals(Pol.MUSKO))
                    rbMusko.Checked = true;
                else
                    rbZensko.Checked = true;
                cbGodine.SelectedItem = polaznici[indeks].Godine;
                cbSkola.SelectedItem = polaznici[indeks].Skola;

                statusLabel.Text = "Selektovan " + polaznici[indeks].Ime + " " + polaznici[indeks].Prezime;
            }
            else
            {
                statusLabel.Text = "Dobrodosli";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (DaLiJeSvePopunjeno())
            {
                Polaznik p = new Polaznik();
                p.Ime = tbIme.Text;
                p.Prezime = tbPrezime.Text;
                p.Pol = rbMusko.Checked ? Pol.MUSKO : Pol.ZENSKO;
                p.Godine = (int)cbGodine.SelectedItem;
                p.Skola = cbSkola.SelectedItem.ToString();
                polaznici.Add(p);

                dgwPodaci.DataSource = polaznici.ToList();
                OcistiPolja();
            }
            else
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
        }

        private void porukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sve radi. :)");
        }

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaLiJeRedSelektovan())
            {
                int indeks = dgwPodaci.SelectedRows[0].Index;
                polaznici.RemoveAt(indeks);

                dgwPodaci.DataSource = polaznici.ToList();
                OcistiPolja();
            }
            else
            {
                MessageBox.Show("Red nije selektovan!");
            }
        }

        private void izmeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaLiJeRedSelektovan())
            {

                if (DaLiJeSvePopunjeno())
                {
                    int indeks = dgwPodaci.SelectedRows[0].Index;
                    polaznici[indeks].Ime = tbIme.Text;
                    polaznici[indeks].Prezime = tbPrezime.Text;
                    polaznici[indeks].Pol = rbZensko.Checked ? Pol.ZENSKO : Pol.MUSKO;
                    polaznici[indeks].Godine = int.Parse(cbGodine.SelectedItem.ToString());
                    polaznici[indeks].Skola = cbSkola.SelectedItem.ToString();

                    dgwPodaci.DataSource = polaznici.ToList();
                    OcistiPolja();
                }
                else
                {
                    MessageBox.Show("Nisu popunjena sva polja!");
                }
            }
            else
            {
                MessageBox.Show("Red nije selektovan!");
            }

        }

        private void sacuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder s = new StringBuilder();
                foreach(Polaznik p in polaznici)
                {
                    s.Append(p.Ime + " " + p.Prezime + "\n");
                }

                File.WriteAllText(saveFileDialog1.FileName, s.ToString());
            }
        }
    }
}
