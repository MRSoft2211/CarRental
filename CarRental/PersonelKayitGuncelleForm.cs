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
    public partial class PersonelKayitGuncelleForm : Form
    {
        public static int ID;
        public static string Ad;
        public static string Soyad;
        public static string EPosta;
        public static string Tel;
        public static string TcNo;
        public static string Adres;
        

        public static bool Control = false;

        public PersonelKayitGuncelleForm()
        {
            InitializeComponent();
        }
        public void KayitGuncelle()
        {
            if (ID != 0)
            {
                AnaMenuForm.Baglanti();
                string Sorgu = "Update Personel Set TcNo=@TcNo,Ad=@Ad,Soyad=@Soyad,Tel=@Tel,Adres=@Adres,EPosta =@EPosta Where PersonelID = @PersonelID";


                SqlCommand GuncelleKomut = new SqlCommand(Sorgu, AnaMenuForm.con);

                GuncelleKomut.Parameters.AddWithValue("@TcNo", maskTxtTc.Text);
                GuncelleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                GuncelleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                GuncelleKomut.Parameters.AddWithValue("@Tel", maskTxtTel.Text);
                GuncelleKomut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                GuncelleKomut.Parameters.AddWithValue("@EPosta", txtEPosta.Text);
                GuncelleKomut.Parameters.AddWithValue("@PersonelID", txtId.Text);
              

                if (GuncelleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtId.Text + " " + "Nolu Kayıt Güncellendi!");
                AnaMenuForm.con.Close();
            }
        }

        public bool BoslukKontrol()
        {

            bool bos = false;  //Tüm alanlar dolu


            txtEPosta.BackColor = Color.LightYellow;
            txtAdres.BackColor = Color.LightYellow;
            maskTxtTel.BackColor = Color.LightYellow;
            txtSoyad.BackColor = Color.LightYellow;
            txtAd.BackColor = Color.LightYellow;
            maskTxtTc.BackColor = Color.LightYellow;



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

        private void PersonelKayitGüncelleForm_Load(object sender, EventArgs e)
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

        private void btnKayitGuncelleForm_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
            {
                MessageBox.Show("Boş Alanlara Veri Giriniz!", "Dikkat!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                KayitGuncelle();
                AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                frm.btnKayitListele.PerformClick();
            }
        }
    }
}
