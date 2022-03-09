using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class Form1 : Form
    {
        public static List<Ucenik> list = new List<Ucenik>();

        public Form1()
        {
            InitializeComponent();
            InitTable();
        }
    
        private void InitTable()
        {
            
            list.Add(new Ucenik("Jovan", "Jovanovic", 1));
            list.Add(new Ucenik("Pera", "Peric", 1));
            list.Add(new Ucenik("Mika", "Mikic", 2));
            list.Add(new Ucenik("Zika", "Zikic", 1));
         
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            dataGridView1.DataSource = bs;
        }

    }
}
