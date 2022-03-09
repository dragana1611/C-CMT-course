using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_1__Restorani
{
    public partial class DodavanjeRestorana : UserControl
    {
        public DodavanjeRestorana()
        {
            InitializeComponent();
        }

        public Restoran Restoran
        {
            get { return PokupiVrednostiRestorana(); }
        }

        public void OcistiUneto()
        {
            textBoxNaziv.Text = String.Empty;
            textBoxAdresa.Text = String.Empty;
            textBoxSpecijalitet.Text = String.Empty;
            checkBoxOtvoren.Checked = false;
            rbDomaci.Checked = true;
        }
        private Restoran PokupiVrednostiRestorana()
        {
            errorProvider1.SetError(this.textBoxNaziv, String.Empty);
            errorProvider1.SetError(this.textBoxAdresa, String.Empty);
            errorProvider1.SetError(this.textBoxSpecijalitet, String.Empty);

            if (textBoxNaziv.Text.Equals("") || textBoxAdresa.Text.Equals("")
                || textBoxSpecijalitet.Text.Equals(""))
            {
                if(textBoxNaziv.Text.Equals(""))
                    errorProvider1.SetError(this.textBoxNaziv, "Niste popunili naziv");

                if (textBoxAdresa.Text.Equals(""))
                    errorProvider1.SetError(this.textBoxAdresa, "Niste popunili adresu");
            
                if (textBoxSpecijalitet.Text.Equals(""))
                    errorProvider1.SetError(this.textBoxSpecijalitet, "Niste popunili specijalitet");
          
                return null;
            }
            else
            { 


                Restoran restoran = new Restoran();
                restoran.Naziv = textBoxNaziv.Text;
                restoran.Adresa = textBoxAdresa.Text;
                restoran.Specijalitet = textBoxSpecijalitet.Text;
                restoran.DaLiJeOtvoren = checkBoxOtvoren.Checked;
                if (rbDomaci.Checked)
                {
                    restoran.TipRestorana = Tip.domaci;
                }
                else if (rbStrani.Checked)
                {
                    restoran.TipRestorana = Tip.strani;
                }
                return restoran;
            }
            

        }
        

    }
}
