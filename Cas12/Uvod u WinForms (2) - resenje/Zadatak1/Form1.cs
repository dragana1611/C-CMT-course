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
            InitComboBox();
            
        }

        private void InitComboBox()
        {
            List<string> list = new List<string>();
            for (int i = 2020; i >= 0; i--)
            {
                list.Add(i.ToString());
            }
            comboBox1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imeAutora = textBox1.Text;
            string nazivKnjige = textBox2.Text;
            string godinaIzdavanja = comboBox1.SelectedValue.ToString();

            if (imeAutora.Equals("") || nazivKnjige.Equals("") || godinaIzdavanja.Equals(""))
            {
                MessageBox.Show(" Morate popuniti sva polja!", "Error");
            }
            else
            { 
                string rbr = dataGridView1.RowCount+1+".";
                dataGridView1.Rows.Add(rbr, imeAutora, nazivKnjige, godinaIzdavanja);
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
