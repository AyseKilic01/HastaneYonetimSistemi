using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaYonetimSistemi_HYS.Forms
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            loadTimer.Interval++;
            if (loadTimer.Interval == 70)
            {
                frmBeg frm = new frmBeg();
                frm.Show();
                loadTimer.Enabled = false;
                this.Hide();
            }
        }
    }
}
