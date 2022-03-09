using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_2___Studenti
{
    public partial class ucFormDodajStudenta : UserControl
    {
        public ucFormDodajStudenta()
        {
            InitializeComponent();
            comboBoxSmer.DataSource = Enum.GetValues(typeof(Smer));
            comboBoxSmer.SelectedIndex = 0;
            comboBoxGodina.SelectedIndex = 0;
        }

        public Student Student
        {
            get { return IscitajSvePodatke(); }
        }

        private Student IscitajSvePodatke()
        {
            errorProvider1.SetError(textBoxIme, "");
            errorProvider1.SetError(textBoxPrezime, "");
            errorProvider1.SetError(textBoxIndex, "");

            if (textBoxIme.Text != "" && textBoxPrezime.Text != "" && textBoxIndex.Text != "")
            {

                if (!int.TryParse(textBoxIndex.Text, out int broj))
                {
                    errorProvider1.SetError(textBoxIndex, "Niste dobro uneli broj indeksa. ");
                    return null;
                }
                else
                {
                    Student student = new Student();
                    student.Ime = textBoxIme.Text;
                    student.Prezime = textBoxPrezime.Text;
                    student.BrIndeksa = int.Parse(textBoxIndex.Text);
                    student.DatumRodjenja = DateTime.Parse(dateTimePickerDatumRodjenja.Text);
                    student.Smer = (Smer)Enum.ToObject(typeof(Smer), comboBoxSmer.SelectedIndex);
                    if (radioButtonMuski.Checked)
                    {
                        student.Pol = Pol.Musko;
                    }
                    else
                    {
                        student.Pol = Pol.Zensko;
                    }
                    student.GodinaStudiranja = comboBoxGodina.SelectedIndex+1;

                    foreach (Predmet item in checkedListBoxPredmeti.SelectedItems)
                    {
                        student.DodajStudentuPredmet(item);
                    }

                    return student;
                }
            }
            else
            {
                if (textBoxIme.Text == "")
                {
                    errorProvider1.SetError(textBoxIme, "Niste popunili ime");
                }
                if (textBoxPrezime.Text == "")
                {
                    errorProvider1.SetError(textBoxPrezime, "Niste popunili prezime");
                }
                if (textBoxIndex.Text == "")
                {
                    errorProvider1.SetError(textBoxIndex, "Niste popunili index");
                }
                return null;
            }
        }

        public void OcistiPolja()
        {
            textBoxIme.Text = "";
            textBoxPrezime.Text =  "";
            textBoxIndex.Text = "";
            radioButtonMuski.Checked = true;
            comboBoxSmer.SelectedIndex = 0;
            comboBoxGodina.SelectedIndex = 0;
            foreach (int i in checkedListBoxPredmeti.CheckedIndices)
            {
                checkedListBoxPredmeti.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        // u zavisnosti od selektovane godine prikazuju se razliciti predmeti
        private void comboBoxGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            int godina = comboBoxGodina.SelectedIndex + 1;
            List<Predmet> predmetiPoGodini = new List<Predmet>();

            foreach (Predmet predmet in BazaPodataka.listaPredmeta.Values)
            {
                if (predmet.Godina == godina)
                    predmetiPoGodini.Add(predmet);
            }

            checkedListBoxPredmeti.DataSource = predmetiPoGodini.ToList();
        }
    }
}
