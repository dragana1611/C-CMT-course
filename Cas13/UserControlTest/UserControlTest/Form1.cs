﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string grad = ucGrad.Grad;
            MessageBox.Show("Izabrali ste "+ grad);
        }
    }
}
