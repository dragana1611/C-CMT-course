using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class UcGrad : UserControl
    {
        List<string> gradovi = new List<string>();
        public UcGrad()
        {
            InitializeComponent();
        }

        public string Grad
        {
            get { return cbGrad.SelectedValue.ToString(); }
        }
        private void UcGrad_Load(object sender, EventArgs e)
        {
            gradovi.Add("Novi Sad");
            gradovi.Add("Beograd");
            gradovi.Add("Niš");
            gradovi.Add("Paraćin");
            gradovi.Add("Subotica");
            gradovi.Add("Vršac");
            cbGrad.DataSource = gradovi;
        }
    }
}
