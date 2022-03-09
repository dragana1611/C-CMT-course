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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            try
            {
                pictureBox1.Image = Image.FromFile("../../cmt.png");
            }
            catch
            {
                MessageBox.Show("Doslo je do problema sa ucitavanjem slike!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            o.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";

            if(o.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(o.FileName);
                    tabControl1.SelectedTab = tabPage1;
                }
                catch
                {
                    MessageBox.Show("Doslo je do problema sa ucitavanjem slike!");
                }
            }
        }
    }
}
