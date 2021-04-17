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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pcExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcDoctor_Click(object sender, EventArgs e)
        {
            Forms.DoctorManage frm = new DoctorManage();
            frm.Show();
            this.Hide();
        }

        private void pcPatient_Click(object sender, EventArgs e)
        {

        }

        private void pcDiagnosis_Click(object sender, EventArgs e)
        {

        }
    }
}
