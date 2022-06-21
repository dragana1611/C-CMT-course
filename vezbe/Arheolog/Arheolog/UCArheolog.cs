using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Arheolog
{
    public partial class UCArheolog : UserControl
    {
       public static List<Arheolog> arheolozi = new List<Arheolog>();
        
        public UCArheolog()
        {
            InitializeComponent();
            UcitajArheologe();

        }


        private void UCArheolog_Load(object sender, EventArgs e)
        { 
            
            lbPrikaz.DataSource = arheolozi;
            lbPrikaz.SelectedIndex = -1;
        }

         public void UcitajArheologe()
         {
            string putanja = "arheolozi.txt";
            StreamReader sr = new StreamReader(putanja);
            while (!sr.EndOfStream)
            {
                try
                {
                    string line = sr.ReadLine();

                    string[] podaci = line.Split('|');
                    Arheolog a = new Arheolog();

                    a.IdArh = podaci[0];
                    a.Ime = podaci[1];
                    a.Prezime = podaci[2];
                    a.Adresa = podaci[3];
                    a.Grad = podaci[4];
                    a.Drzava = podaci[5];
                    a.Email = podaci[6];
                    a.BrTel = podaci[7];

                    arheolozi.Add(a);

                }
                catch (Exception ex)
                {
                    throw;
                    MessageBox.Show("Doslo je do problema sa ucitavanjem txt fajla!", ex.Message);
                }
            }
            sr.Close();
        }



    }
}
            
 
    
