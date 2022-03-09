using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2Primer
{
    public partial class Form1 : Form
    {
        List<Fudbaler> fudbaleri = new List<Fudbaler>();

        public Form1()
        {
            InitializeComponent();
            InicijalizujFudbalere();
            sistem.DataSource = fudbaleri.ToList();
            comboBox.DataSource = Enum.GetValues(typeof(Pozicija));
        }

        private void InicijalizujFudbalere()
        {
            fudbaleri.Add(new Fudbaler(10, "Lazar", "Messy", DateTime.Today, Pozicija.NAPAD));
            fudbaleri.Add(new Fudbaler(7, "Krsto", "Ronaldo", DateTime.Parse("1/8/2000"), Pozicija.NAPAD));
            fudbaleri.Add(new Fudbaler(4, "Nick", "Vidic", DateTime.Parse("1990/11/1"), Pozicija.ODBRANA));
            OsveziProgressBar();
        }

        private void OsveziProgressBar()
        {
            statusLabel.Text = "Sistem poseduje trenutno " + fudbaleri.Count + ". fudbalera";

            if (fudbaleri.Count > 11)
                progressBar.Value = 100;
            else
                progressBar.Value = fudbaleri.Count * 100 / 11;
        }

        private bool DaLiJeSvePopunjeno()
        {
            bool retVal = true;

            if(tbIme.Text == "" || tbPrezime.Text == "" || tbBrojDresa.Text == "")
            {
                retVal = false;
            }

            return retVal;
        }

        private bool DaLiJeRedSelektovan()
        {
            bool retVal = true;

            if (sistem.SelectedRows.Count == 0)
            {
                retVal = false;
            }

            return retVal;
        }

        private void OcistiPolja()
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbBrojDresa.Text = "";
            sistem.ClearSelection();
        }

        private void oAutoruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iva Ivic, postovalac i ljubitelj fudbala.");
        }

        private void cMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void zatvoriProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Da li ste sigurni da zelite da napustite program?", "Izlazak", MessageBoxButtons.YesNo);

            if (rezultat.Equals(DialogResult.Yes))
                this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(DaLiJeSvePopunjeno())
            {
                Fudbaler f = new Fudbaler();
                f.BrojDresa = int.Parse(tbBrojDresa.Text);
                f.Ime = tbIme.Text;
                f.Prezime = tbPrezime.Text;
                f.DatumRodjenja = DateTime.Parse(dateTimePicker.Text);
                f.PozicijaFudbalera = (Pozicija)comboBox.SelectedIndex;

                fudbaleri.Add(f);
                sistem.DataSource = fudbaleri.ToList();
                OsveziProgressBar();
                OcistiPolja();
            }
            else
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
        }

        private void sistem_SelectionChanged(object sender, EventArgs e)
        {
            if (sistem.SelectedRows.Count > 0)
            {
                int indeks = sistem.SelectedRows[0].Index;
                tbBrojDresa.Text = fudbaleri[indeks].BrojDresa.ToString();
                tbIme.Text = fudbaleri[indeks].Ime;
                tbPrezime.Text = fudbaleri[indeks].Prezime;
                dateTimePicker.Value = fudbaleri[indeks].DatumRodjenja;
                comboBox.SelectedIndex = (int)fudbaleri[indeks].PozicijaFudbalera;

            }
        }

        private void bnIzmeni_Click(object sender, EventArgs e)
        {
            if (DaLiJeSvePopunjeno())
            {
                if (DaLiJeRedSelektovan())
                {
                    int indeks = sistem.SelectedRows[0].Index;
                    fudbaleri[indeks].BrojDresa = int.Parse(tbBrojDresa.Text);
                    fudbaleri[indeks].Ime = tbIme.Text;
                    fudbaleri[indeks].Prezime = tbPrezime.Text;
                    fudbaleri[indeks].DatumRodjenja = dateTimePicker.Value;
                    fudbaleri[indeks].PozicijaFudbalera = (Pozicija)comboBox.SelectedIndex;

                    sistem.DataSource = fudbaleri.ToList();
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (DaLiJeRedSelektovan())
            {
                int indeks = sistem.SelectedRows[0].Index;
                fudbaleri.RemoveAt(indeks);

                sistem.DataSource = fudbaleri.ToList();
                OsveziProgressBar();
                OcistiPolja();
            }
            else
            {
                MessageBox.Show("Red nije selektovan!");
            }
        }
    }
}
