using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaYonetimSistemi_HYS.Entities;

namespace HastaYonetimSistemi_HYS
{
    public partial class frmBeg : Form
    {
        HastaneYonetimSistemiEntities db = new HastaneYonetimSistemiEntities();
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

        private void frmBeg_Load(object sender, EventArgs e)
        {
            var users = (from i in db.TblDoktor
                         select new
                         {
                             ad = i.Ad + i.Soyad
                         });
            foreach (var i in users)
            {
                cmbName.Properties.Items.Add(i.ad);
            }
        }
    }
}
