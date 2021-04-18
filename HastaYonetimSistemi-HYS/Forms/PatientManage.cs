using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HastaYonetimSistemi_HYS.Entities;

namespace HastaYonetimSistemi_HYS.Forms
{
    public partial class PatientManage : Form
    {
        HastaneYonetimSistemiEntities db = new HastaneYonetimSistemiEntities();
        public PatientManage()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtAdres.Text = "";
            txtHastalik.Text = "";
            txtTelefon.Text = "";
            txtYas.Text = "";
            cmbCinsiyet.EditValue = "";
            cmbGrup.EditValue = "";
        }
        private void Listele()
        {
            listPatient.Items.Clear();
            var degerler = (from x in db.TblHasta
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Soyad,
                                x.Adres,
                                x.Hastalık,
                                x.Yas,
                                x.Telefon,
                                x.KanGrubu,
                                x.Cinsiyet

                            }).ToList();
            foreach (var d in degerler)
            {
                ListViewItem list = new ListViewItem();
                list.Text = d.ID.ToString();
                list.SubItems.Add(d.Ad.ToString());
                list.SubItems.Add(d.Soyad.ToString());
                list.SubItems.Add(d.Adres.ToString());
                list.SubItems.Add(d.Telefon.ToString());
                list.SubItems.Add(d.Yas.ToString());
                list.SubItems.Add(d.Hastalık.ToString());
                list.SubItems.Add(d.Cinsiyet.ToString());
                list.SubItems.Add(d.KanGrubu.ToString());
                listPatient.Items.Add(list);
            }
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Hide();
        }
        int id = 0;
        private void listPatient_Click(object sender, EventArgs e)
        {
            id = int.Parse(listPatient.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listPatient.SelectedItems[0].SubItems[1].Text.Trim();
            txtSoyad.Text = listPatient.SelectedItems[0].SubItems[2].Text.Trim();
            txtAdres.Text = listPatient.SelectedItems[0].SubItems[3].Text.Trim();
            txtTelefon.Text = listPatient.SelectedItems[0].SubItems[4].Text.Trim();
            txtYas.Text = listPatient.SelectedItems[0].SubItems[5].Text.Trim();
            txtHastalik.Text = listPatient.SelectedItems[0].SubItems[6].Text.Trim();
            cmbCinsiyet.EditValue = listPatient.SelectedItems[0].SubItems[7].Text.Trim();
            cmbGrup.EditValue = listPatient.SelectedItems[0].SubItems[8].Text.Trim();
        }

        bool Control()
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTelefon.Text != ""
            && txtHastalik.Text != "")
                return true;
            return false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Control())
            {
                TblHasta t = new TblHasta();
                t.Ad = txtAd.Text;
                t.Soyad = txtSoyad.Text;
                t.Yas = int.Parse(txtYas.Text);
                t.Hastalık = txtHastalik.Text;
                t.Telefon = txtTelefon.Text;
                t.Adres = txtAdres.Text;
                t.Cinsiyet = cmbCinsiyet.SelectedItem.ToString();
                t.KanGrubu = cmbGrup.SelectedItem.ToString();
                db.TblHasta.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni Hasta Eklendi");
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
            var deger = db.TblHasta.Find(id);
            deger.Ad = txtAd.Text;
            deger.Soyad = txtSoyad.Text;
            deger.Adres = txtAdres.Text;
            deger.Telefon = txtTelefon.Text;
            deger.Hastalık = txtHastalik.Text;
            deger.Yas = int.Parse(txtYas.Text);
            deger.Cinsiyet = cmbCinsiyet.SelectedItem.ToString();
            deger.KanGrubu = cmbGrup.SelectedItem.ToString();
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi");
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (id != null && id != 0)
            {
                var deger = db.TblHasta.Find(id);
                db.TblHasta.Remove(deger);
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void PatientManage_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
