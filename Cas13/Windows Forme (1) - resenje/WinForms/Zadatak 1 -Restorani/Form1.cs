using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_1__Restorani
{
    public partial class Form1 : Form
    {
        List<Restoran> restorani = new List<Restoran>();
        public Form1()
        {
            InitializeComponent();
            dataGridViewRestorani.DataSource = restorani.ToList();
        }

        private void btnDodajRestoran_Click(object sender, EventArgs e)
        {
            Restoran restoran = dodavanjeRestorana1.Restoran;
           
            if(restoran!=null)
            {
                restorani.Add(restoran);
                dataGridViewRestorani.DataSource = restorani.ToList();
                MessageBox.Show("Uspesno ste dodali restoran");
                dodavanjeRestorana1.OcistiUneto();
            }
        }
    }
}
