﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaYonetimSistemi_HYS
{
    public partial class frmBeg : Form
    {
        public frmBeg()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Forms.Home frm = new Forms.Home();
            frm.Show();
            this.Hide();
        }
    }
}
