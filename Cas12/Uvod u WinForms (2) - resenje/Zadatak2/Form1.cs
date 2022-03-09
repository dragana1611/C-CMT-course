using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void dodavanjeSkoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajSkolu ds = new DodajSkolu();
            ds.ShowDialog();
        }

        private void dodavanjeUcenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajUcenika du = new DodajUcenika();
            du.ShowDialog();

        }
    }
}
