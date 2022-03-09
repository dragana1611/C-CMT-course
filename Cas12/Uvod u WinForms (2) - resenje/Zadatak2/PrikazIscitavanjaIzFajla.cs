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
    public partial class PrikazIscitavanjaIzFajla : Form
    {
        // napravili smo dva konstruktora u zavisnsti od toga sta treba da se prikaze
        public PrikazIscitavanjaIzFajla(List<Ucenik> listaUcenika)
        {
            InitializeComponent();
            dataGridView1.DataSource = listaUcenika;
            CenterToParent();
        }

        public PrikazIscitavanjaIzFajla(List<Skola> listaSkola)
        {
            InitializeComponent();
            dataGridView1.DataSource = listaSkola;
            CenterToParent();
        }
    }
}
