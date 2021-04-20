﻿using System;
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
    public partial class DiagnosisManage : Form
    {
        HastaneYonetimSistemiEntities db = new HastaneYonetimSistemiEntities();
        public DiagnosisManage()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            txtAd.Text = "";
            txtBelirti.Text = "";
            txtIlac.Text = "";
            txtSonuc.Text = "";
        }
        private void ListeleHasta()
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
    
    private void ListeleSonuc()
    {
        listSonuc.Items.Clear();
        var degerler = (from x in db.TblSonuclar
                        select new
                        {
                            x.ID,
                            x.Ad,
                            x.HastaID,
                            x.Ilaclar,
                            x.Belirtiler

                        }).ToList();
        foreach (var d in degerler)
        {
            ListViewItem list = new ListViewItem();
            list.Text = d.ID.ToString();
            list.SubItems.Add(d.Ad.ToString());
            list.SubItems.Add(d.HastaID.ToString());
            list.SubItems.Add(d.Ilaclar.ToString());
            list.SubItems.Add(d.Belirtiler.ToString());
            listSonuc.Items.Add(list);
        }
    }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Hide();
        }
        int id = 0;
        private void listSonuc_Click(object sender, EventArgs e)
        {
            id = int.Parse(listSonuc.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listSonuc.SelectedItems[0].SubItems[1].Text.Trim();
            txtSonuc.Text = listSonuc.SelectedItems[0].SubItems[2].Text.Trim();
            txtBelirti.Text = listSonuc.SelectedItems[0].SubItems[3].Text.Trim();
            txtIlac.Text = listSonuc.SelectedItems[0].SubItems[4].Text.Trim();
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        bool Control()
        {
            if (txtAd.Text != "" && txtBelirti.Text != "" 
            && txtSonuc.Text != "")
                return true;
            return false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Control())
            {
                TblSonuclar t = new TblSonuclar();
                t.Ad = txtSonuc.Text;
                t.Belirtiler = txtBelirti.Text;
                t.Ilaclar = txtIlac.Text;
                t.HastaID = int.Parse(txtAd.Text);
                db.TblSonuclar.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni Sonuç Eklendi");
                ListeleSonuc();
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
            var deger = db.TblSonuclar.Find(id);
            deger.Ad = txtSonuc.Text;
            deger.Belirtiler = txtBelirti.Text;
            deger.Ilaclar = txtIlac.Text;
            deger.HastaID = int.Parse(txtAd.Text);
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi");
            ListeleSonuc();
            Temizle();
        }

        private void DiagnosisManage_Load(object sender, EventArgs e)
        {
            ListeleHasta();
            ListeleSonuc();
        }
    }
}
