using System;
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
    public partial class AracGuncelleForm : Form
    {
        public static int ID;
        public static string AracMarka;
        public static string AracModel;
        public static string AracModelYili;
        public static string AracKm;
        public static string AracRenk;
        public static string AracMotorGucu;
        public static string AracMotorHacmi;
        public static string AracVites;
        public static string AracKasaTipi;
        public static string AracCekis;
        public static string AracYakitTipi;
        public static string AracPlaka;
        public static string AracPaket;
        public static string AracVersiyon;
        public static string AracSasiNo;
        public static string AracGunlukFiyat;
        public static bool Control = false;



        public AracGuncelleForm()
        {
            InitializeComponent();
        }

        public void AracGuncelle()
        {
            if (ID != 0)
            {
                AnaMenuForm.Baglanti();
                string Sorgu = "Update aracTanimla Set AracKm=@AracKm,AracPlaka=@AracPlaka,AracRenk=@AracRenk,AracMarka=@AracMarka," +
                    "AracModel=@AracModel,AracGunlukFiyat=@AracGunlukFiyat Where AracID = @ID";




                SqlCommand GuncelleKomut = new SqlCommand(Sorgu, AnaMenuForm.con);
                GuncelleKomut.Parameters.AddWithValue("@AracMarka", txtMarka.Text);
                GuncelleKomut.Parameters.AddWithValue("@AracModel", txtModel.Text);
                GuncelleKomut.Parameters.AddWithValue("@AracPlaka", txtPlaka.Text);
                GuncelleKomut.Parameters.AddWithValue("@AracKm", mktxtKm.Text);
                GuncelleKomut.Parameters.AddWithValue("@AracRenk", cmbRenk.Text);
                GuncelleKomut.Parameters.AddWithValue("@AracGunlukFiyat", txtAracGunlukFiyat.Text);
                GuncelleKomut.Parameters.AddWithValue("@ID", txtAracID.Text);


                if (GuncelleKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtAracID.Text + " " + "Nolu Kayıt Güncellendi!");
                    AnaMenuForm.con.Close();
                }
            }
        }

        public bool BoslukKontrol ()
        {
            bool bos = false;
            txtMarka.BackColor = Color.PeachPuff;
            txtModel.BackColor = Color.PeachPuff;
            txtPlaka.BackColor = Color.PeachPuff;
            cmbRenk.BackColor = Color.PeachPuff;
            mktxtKm.BackColor = Color.PeachPuff;
            txtAracGunlukFiyat.BackColor = Color.PeachPuff;

            if (txtAracGunlukFiyat.Text == "")
            {
                txtAracGunlukFiyat.BackColor = Color.Red;
                txtAracGunlukFiyat.Focus();
                bos = true;
            }
            if (txtPlaka.Text == "")
            {
                txtPlaka.BackColor = Color.Red;
                txtPlaka.Focus();
                bos = true;
            }
            if (mktxtKm.Text == "")
            {
                mktxtKm.BackColor = Color.Red;
                mktxtKm.Focus();
                bos = true;
            }
            if (cmbRenk.Text == "")
            {
                cmbRenk.BackColor = Color.Red;
                cmbRenk.Focus();
                bos = true;
            }

            if (txtModel.Text == "")
            {
                txtModel.BackColor = Color.Red;
                txtModel.Focus();
                bos = true;
            }
            if (txtMarka.Text == "")
            {
                txtMarka.BackColor = Color.Red;
                txtMarka.Focus();
                bos = true;
            }
            
           



            return bos;

        }
        private void AracGuncelleForm_Load(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                txtAracID.Text = ID.ToString();
                mktxtKm.Text = AracKm;
                cmbRenk.Text = AracRenk;
                txtPlaka.Text = AracPlaka;
                txtMarka.Text = AracMarka;
                txtModel.Text = AracModel;
                txtAracGunlukFiyat.Text = AracGunlukFiyat;
            }
          

        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
            {
                MessageBox.Show("Boş Alanlara Veri Giriniz!", "Dikkat!");
            }
            else
            {
                AracGuncelle();
            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
            frm.btnAracListele.PerformClick();
         

            }
        }
    }
}

