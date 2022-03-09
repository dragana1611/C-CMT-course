using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak2
{
    public partial class DodajUcenika : Form
    {
        private static Dictionary<int, Ucenik> listaUcenika 
            = new Dictionary<int, Ucenik>();
        private static int idUcenika = 0;

        public DodajUcenika()
        {
            InitializeComponent();

            CenterToParent();
            dataGridView1.DataSource = listaUcenika.Values.ToList();

            InitCBSkola();
            cbRazred.SelectedIndex = 0;
        }


        public void InitCBSkola()
        {
            if (DodajSkolu.ListaSkola.Count>0)
            {
                cbSkola.DataSource = new BindingSource(DodajSkolu.ListaSkola, null);
                cbSkola.DisplayMember = "Value";
            }

        }

        public void ClearText()
        {
            imeUcenika.Clear();
            prezimeUcenika.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imeUcenika.Text.Equals("") || prezimeUcenika.Text.Equals("") || cbRazred.SelectedIndex==-1 )
            {
                MessageBox.Show("Niste uneli sva polja!");
            }
            else
            {
                int razred = int.Parse(cbRazred.SelectedItem.ToString());
                int indexSkole = cbSkola.SelectedIndex;
                Ucenik ucenik = new Ucenik(imeUcenika.Text, prezimeUcenika.Text,
                    razred, datumRodjenja.Value, DodajSkolu.ListaSkola[indexSkole]);
                DodajUcenikaUListu(ucenik);
            }
        }
        private void DodajUcenikaUListu(Ucenik ucenik)
        {
            listaUcenika.Add(idUcenika, ucenik);
            idUcenika++;
            dataGridView1.DataSource = listaUcenika.Values.ToList();

            ClearText();
        }

        private void UpisiUcenikeUFajl_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog1.FileName;
                    BinaryFormatter formatter = new BinaryFormatter();
                    
                    Stream stream = new FileStream(fileName, FileMode.OpenOrCreate);
                    formatter.Serialize(stream, listaUcenika.Values.ToList());
                    MessageBox.Show("Uspešno ste upisali sve Ucenike u fajl " + fileName);

                    stream.Dispose();
                }
            }
        }

        private void IscitajUcenikeIzFajla_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Multiselect = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Stream stream = openFileDialog1.OpenFile();
                        if (stream != null)
                        {
                            string fileName = openFileDialog1.FileName;
                            BinaryFormatter formatter = new BinaryFormatter();

                            List<Ucenik> list = (List<Ucenik>)formatter.Deserialize(stream);
                            PrikazIscitavanjaIzFajla prikaz = new PrikazIscitavanjaIzFajla(list);
                            prikaz.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

           
        }
    }
}
