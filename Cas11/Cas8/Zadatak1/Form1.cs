using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonMusko.Checked = true;
        }

        private void buttonOcisti_Click(object sender, EventArgs e)
        {
            Ocisti();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            string ime = textBoxIme.Text;
            string prezime = textBoxPrezime.Text;
            bool daLiJeStudent = checkBoxStudent.Checked;
            string pol = "";
            if (radioButtonMusko.Checked)
            {
                pol = "Musko";
            }
            else if (radioButtonZensko.Checked)
            {
                pol = "Zensko";
            }
            dataGridView1.Rows.Add(ime, prezime, pol, daLiJeStudent);
            Ocisti();
        }

        public void Ocisti()
        {
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            checkBoxStudent.Checked = false;
            radioButtonMusko.Checked = true;
        }
    }
}
