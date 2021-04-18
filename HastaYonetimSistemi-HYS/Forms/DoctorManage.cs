using DevExpress.XtraEditors;
using HastaYonetimSistemi_HYS.Entities;
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
    public partial class DoctorManage : Form
    {
        HastaneYonetimSistemiEntities db = new HastaneYonetimSistemiEntities();
        public DoctorManage()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtSifre.Text = "";
            txtDeneyim.Text = "";
        }
        private void Listele()
        {
            listDoctor.Items.Clear();
            var degerler = (from x in db.TblDoktor
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Soyad,
                                x.Deneyim,
                                x.Sifre

                            }).ToList();
            foreach (var d in degerler)
            {
                ListViewItem list = new ListViewItem();
                list.Text = d.ID.ToString();
                list.SubItems.Add(d.Ad.ToString());
                list.SubItems.Add(d.Soyad.ToString());
                list.SubItems.Add(d.Sifre.ToString());
                list.SubItems.Add(d.Deneyim.ToString());
                listDoctor.Items.Add(list);
            }
        }
        int id = 0;
        private void listDoctor_Click(object sender, EventArgs e)
        {
            id = int.Parse(listDoctor.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listDoctor.SelectedItems[0].SubItems[1].Text.Trim();
            txtSoyad.Text = listDoctor.SelectedItems[0].SubItems[2].Text.Trim();
            txtSifre.Text = listDoctor.SelectedItems[0].SubItems[3].Text.Trim();
            txtDeneyim.Text = listDoctor.SelectedItems[0].SubItems[4].Text.Trim();

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Hide();
        }
        bool Control()
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtSifre.Text != ""
            && txtDeneyim.Text != "")
                return true;
            return false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Control())
            {
                TblDoktor t = new TblDoktor();
                t.Ad = txtAd.Text;
                t.Soyad = txtSoyad.Text;
                t.Deneyim = int.Parse(txtDeneyim.Text);
                t.Sifre = txtSifre.Text;
                db.TblDoktor.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni Doktor Eklendi");
                Listele();
                Temizle();
            }
            else
            {
                XtraMessageBox.Show("Alanlar boş olamaz !!");
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = db.TblDoktor.Find(id);
            deger.Ad = txtAd.Text;
            deger.Soyad = txtSoyad.Text;
            deger.Sifre = txtSifre.Text;
            deger.Deneyim = int.Parse(txtDeneyim.Text);
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi");
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (id != null && id != 0)
            {
                var deger = db.TblDoktor.Find(id);
                db.TblDoktor.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Silindi");
                Listele();
                Temizle();
            }
            else
            {
                XtraMessageBox.Show("Satır seçiniz !!");
            }
        }

        private void DoctorManage_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
