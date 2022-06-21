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
    public partial class AntikvitetInfo : Form
    {
        public AntikvitetInfo()
        {
            InitializeComponent();
        }

        //zatvaranje mini forme
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        //provera da li su sva polja popunjena
        public bool DaLiJeSvePopunjeno()
        {
            bool retVal = true;

            if (tbNaziv.Text == "" || tbDatPronal.Text == "" || tbPeriod.Text == "" || tbTipAntikv.Text == "" || tbLokalitet.Text == "" || tbImgNaziv.Text == "")
            {
                retVal = false;
            }

            return retVal;
        }

        //reset polja
        public void OcistiPolja()
        {
            tbNaziv.Text = "";
            tbDatPronal.Text = "";
            tbPeriod.Text = "";
            tbTipAntikv.Text = "";
            tbLokalitet.Text = "";
            tbImgNaziv.Text = "";
        }

        private void btnDodavanjeUC_Click(object sender, EventArgs e)
        {

        }

        private void btnBrisanjeAntikviteta_Click(object sender, EventArgs e)
        {

        }
    }
}
