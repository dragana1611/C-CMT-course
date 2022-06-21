using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arheolog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UpravljanjeUC mnguc = new UpravljanjeUC();

        private void btnModalBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("APLIKACIJA: Klijentska strana je realizovana u vidu WinForme. Pozdrav, korisnice! Ova aplikacija je podeljena u vise tabova, po funkcionalnostima. Prikaz i izmena podataka: U ovoj sekciji se sastoje tabovi za prikaz i izmenu podataka, kao i opcije specijalne pretrage. Podaci se unose, menjaju i brisu preko textBox - ova pored tabela gde se prikazuju podaci. Pretraga po parametrima: U ovoj sekciji imate izbor po svakoj tabeli i parametru koji mozete pretraziti. Pri zatvaranju aplikacije izmene se upisuju u tekstualnu datoteku.\n" +
                            "AUTOR: Uros Petrovic" , "O APLIKACIJI");
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult izlaz = MessageBox.Show("Da li ste sigurni da zelite da napustite aplikaciju?", "Brisanje", MessageBoxButtons.YesNo);
            if (izlaz == DialogResult.Yes)
                Application.Exit();
        }

        private void btnUCArheolozi_Click(object sender, EventArgs e)
        {
            UCArheolog ucarh = new UCArheolog();
            mnguc.DisplayControl(ucarh, splitContainer1.Panel2);
        }

        private void btnUCAntikviteti_Click(object sender, EventArgs e)
        {
            UCAntikvitet ucant = new UCAntikvitet();
            mnguc.DisplayControl(ucant, splitContainer1.Panel2);
        }
    }
}
