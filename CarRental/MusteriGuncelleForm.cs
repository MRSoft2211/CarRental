﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRental
{
    public partial class MusteriGuncelleForm : Form
    {
        public static int ID;
        public static string Ad;
        public static string Soyad;
        public static string EPosta;
        public static string Tel;
        public static string TcNo;
        public static string Adres;
        public static bool Control;
       
        public MusteriGuncelleForm()
        {
            InitializeComponent();
        }
        public void KayitGuncelle()
        {
            if (ID != 0)
            {
                AnaMenuForm.Baglanti();
                string Sorgu = "Update Musteri Set MusteriTcNo=@MusteriTcNo,MusteriAd=@MusteriAd,MusteriSoyad=@MusteriSoyad," +
                    "MusteriTelefon=@MusteriTelefon,MusteriAdres=@MusteriAdres,MusteriEPosta=@MusteriEPosta Where MusteriID = @MusteriID";


                SqlCommand GuncelleKomut = new SqlCommand(Sorgu, AnaMenuForm.con);

                GuncelleKomut.Parameters.AddWithValue("@MusteriTcNo", maskTxtTc.Text);
                GuncelleKomut.Parameters.AddWithValue("@MusteriAd", txtAd.Text);
                GuncelleKomut.Parameters.AddWithValue("@MusteriSoyad", txtSoyad.Text);
                GuncelleKomut.Parameters.AddWithValue("@MusteriTelefon", maskTxtTel.Text);
                GuncelleKomut.Parameters.AddWithValue("@MusteriAdres", txtAdres.Text);
                GuncelleKomut.Parameters.AddWithValue("@MusteriEPosta", txtEPosta.Text);
                GuncelleKomut.Parameters.AddWithValue("@MusteriID", txtId.Text);


                if (GuncelleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtId.Text + " " + "Nolu Kayıt Güncellendi!");
                AnaMenuForm.con.Close();
            }
        }
        public bool BoslukKontrol()
        {

            bool bos = false;  //Tüm alanlar dolu


            txtEPosta.BackColor = SystemColors.Control;
            txtAdres.BackColor = SystemColors.Control;
            maskTxtTel.BackColor = SystemColors.Control;
            txtSoyad.BackColor = SystemColors.Control;
            txtAd.BackColor = SystemColors.Control;
            maskTxtTc.BackColor = SystemColors.Control;



            if (txtAdres.Text == "")
            {
                txtAdres.BackColor = Color.Red;
                bos = true;
            }

            if (txtEPosta.Text == "")
            {
                txtEPosta.BackColor = Color.Red;
                bos = true;
            }

            if (maskTxtTel.Text == "" || maskTxtTel.Text.Length < 11)
            {
                maskTxtTel.BackColor = Color.Red;
                maskTxtTel.Focus();
                bos = true;
            }


            if (txtSoyad.Text == "")
            {
                txtSoyad.BackColor = Color.Red;
                txtSoyad.Focus();
                bos = true;
            }

            if (txtAd.Text == "")
            {
                txtAd.BackColor = Color.Red;
                txtAd.Focus();
                bos = true;
            }

            if (maskTxtTc.Text == "" || maskTxtTc.Text.Length < 11)
            {
                maskTxtTc.BackColor = Color.Red;
                maskTxtTc.Focus();
                bos = true;
            }

            return bos;
        }

        private void MusteriGuncelleForm_Load(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                txtId.Text = ID.ToString();
                maskTxtTc.Text = TcNo;
                txtAd.Text = Ad;
                txtSoyad.Text = Soyad;
                maskTxtTel.Text = Tel;
                txtEPosta.Text = EPosta;
                txtAdres.Text = Adres;

            }
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
            {
                MessageBox.Show("Boş Alanlara Veri Giriniz!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                KayitGuncelle();
                AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                frm.btnMusteriListele.PerformClick();
            }
        }
    }
}
