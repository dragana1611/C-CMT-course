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
    public partial class DodajSkolu : Form
    {
        private static List<Skola> listaSkola = new List<Skola>();
  
        public static List<Skola> ListaSkola
        {
            get { return listaSkola; }
        }

        public DodajSkolu()
        {
            InitializeComponent();
            CenterToParent();
            AddInitSkole();
            dataGridView1.DataSource = listaSkola.ToList();
        }

        // inicijalno dodajemo da imamo makar dve skole
        public void AddInitSkole()
        {
            listaSkola.Add(new Skola("Jovan Jovanovic Zmaj", "Zlatne grede 4", "Novi Sad"));
            listaSkola.Add(new Skola("Prva beogradska gimnazija", "Cara Dusana 61", "Beograd"));

        }

        private void ClearText()
        {
            imeSkole.Clear();
            adresaSkole.Clear();
            gradSkole.Clear();
        }

        private void DodajSkolu_Click(object sender, EventArgs e)
        {
            if (imeSkole.Text.Equals("") || adresaSkole.Text.Equals("") || gradSkole.Text.Equals(""))
            {
                MessageBox.Show("Niste uneli sva polja!");
            }
            else
            {
                Skola skola = new Skola(imeSkole.Text, adresaSkole.Text, gradSkole.Text);
                DodajSkoluUListu(skola);               
            }
        }

        public void DodajSkoluUListu(Skola skola)
        {
            listaSkola.Add(skola);
            dataGridView1.DataSource = listaSkola.ToList();
            ClearText();
        }
       
        private void UpisiSkole_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog1.FileName;
                    BinaryFormatter formatter = new BinaryFormatter();

                    Stream stream = new FileStream(fileName, FileMode.OpenOrCreate);
                    formatter.Serialize(stream, listaSkola);                   
                    stream.Dispose();

                    MessageBox.Show("Uspešno ste upisali sve Skole u fajl " + fileName);
                }
            }
        }

        private void IscitajSveSkoleIzFajla_Click(object sender, EventArgs e)
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
                            List<Skola> list = (List<Skola>)formatter.Deserialize(stream);

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
