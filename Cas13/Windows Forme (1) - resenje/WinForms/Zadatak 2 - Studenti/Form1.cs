using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_2___Studenti
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = BazaPodataka.studenti.ToList();
        }

        private void buttonDodajStudenta_Click(object sender, EventArgs e)
        {
            Student student = ucFormDodajStudenta1.Student;
            if (student != null)
            {
                BazaPodataka.studenti.Add(student);
                dataGridView1.DataSource = BazaPodataka.studenti.ToList();
                MessageBox.Show("Uspesno ste dodali studenta");
                ucFormDodajStudenta1.OcistiPolja();
            }
        }
    }
}
