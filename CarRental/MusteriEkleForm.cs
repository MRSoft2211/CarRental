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
    public partial class MusteriEkleForm : Form
    {
        public MusteriEkleForm()
        {
            InitializeComponent();
        }
        public void KayitEkle()
        {
            try
            {
                AnaMenuForm.Baglanti();
                string Sorgu = "Insert Into Musteri (MusteriTcNo,MusteriAd,MusteriSoyad,MusteriEPosta,MusteriTelefon,MusteriCinsiyet,MusteriAdres,MusteriDTar)" +
                    "Values(@MusteriTcNo,@MusteriAd,@MusteriSoyad,@MusteriEPosta,@MusteriTelefon,@MusteriCinsiyet,@MusteriAdres,@MusteriDTar)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, AnaMenuForm.con);
                EkleKomut.Parameters.AddWithValue("@MusteriTcNo", maskTxtTc.Text);
                EkleKomut.Parameters.AddWithValue("@MusteriAd", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@MusteriSoyad", txtSoyad.Text.ToUpper());

                if (radBay.Checked == true)
                {
                    EkleKomut.Parameters.AddWithValue("@MusteriCinsiyet", radBay.Text);
                }
                else if (radBayan.Checked == true)
                {
                    EkleKomut.Parameters.AddWithValue("@MusteriCinsiyet", radBayan.Text);
                }
                EkleKomut.Parameters.AddWithValue("@MusteriDTar", dtDTar.Text);
                EkleKomut.Parameters.AddWithValue("@MusteriTelefon", maskTxtTel.Text);
                EkleKomut.Parameters.AddWithValue("@MusteriAdres", txtAdres.Text.ToUpper());
                EkleKomut.Parameters.AddWithValue("@MusteriEPosta", txtEPosta.Text);

                if (EkleKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " " + "İsimli Kayıt Eklendi!");
                }

                AnaMenuForm.con.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
            }
        }
        public bool BoslukKontrol()
        {

            bool bos = false;  //Tüm alanlar dolu

            txtEPosta.BackColor = Color.AntiqueWhite;
            txtAdres.BackColor = Color.AntiqueWhite;
            maskTxtTel.BackColor = Color.AntiqueWhite;
            radBay.BackColor = Color.AntiqueWhite;
            radBayan.BackColor = Color.AntiqueWhite;
            txtSoyad.BackColor = Color.AntiqueWhite;
            txtAd.BackColor = Color.AntiqueWhite;
            maskTxtTc.BackColor = Color.AntiqueWhite;


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


            if (dtDTar.Text == DateTime.Now.ToShortDateString())
            {

                dtDTar.Focus();
                bos = true;
            }

            

            if (radBay.Checked == false && radBayan.Checked == false)
            {
                radBay.BackColor = Color.Red;
                radBayan.BackColor = Color.Red;
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

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            AnaMenuForm.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from Musteri where MusteriTcNo='" + maskTxtTc.Text + "'", AnaMenuForm.con);
            int sonuc = (int)tekrar.ExecuteScalar();
            if (sonuc==0)
            {
                if (BoslukKontrol() == true)
                {
                    MessageBox.Show("Boş Alanlara Veri Giriniz!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    AnaMenuForm.con.Close();
                }
                else
                {
                    AnaMenuForm.con.Close();
                    KayitEkle();
                    this.Close();
                    AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                    frm.btnMusteriListele.PerformClick();
                }

            }
            else if (sonuc > 0)
            {
                MessageBox.Show(txtAd.Text + " " + txtSoyad.Text +" "+"İsimli Kayıt Zaten Var!");
                AnaMenuForm.con.Close();

            }

        }
    }
}
