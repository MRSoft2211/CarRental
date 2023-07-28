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
    public partial class PersonelKayitEkleForm : Form
    {
       

        public PersonelKayitEkleForm()
        {
            InitializeComponent();
        }
        public void KayitEkle()
        {
            string Sifre = txtSoyad.Text.ToUpper();
            string Tc3= maskTxtTc.Text.Substring(0, 3);
            string PersSıfre = Sifre + Tc3;

            try
            {
                AnaMenuForm.Baglanti();
                string Sorgu = "Insert Into Personel (TcNo,Ad,Soyad,DYer,DTar,Tel,Adres,EPosta,Cinsiyet,BayiID,Sifre)" +
                    "Values(@TcNo,@Ad,@Soyad,@DYer,@DTar,@Tel,@Adres,@EPosta,@Cinsiyet,@BayiID,@Sifre)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu,AnaMenuForm.con);
                EkleKomut.Parameters.AddWithValue("@TcNo", maskTxtTc.Text);
                EkleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text.ToUpper());

                if (radBay.Checked == true)
                {
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", radBay.Text);
                }
                else if (radBayan.Checked == true)
                {
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", radBayan.Text);
                }
                EkleKomut.Parameters.AddWithValue("@DYer", cmbDYer.Text.ToUpper());
                EkleKomut.Parameters.AddWithValue("@DTar", dtDTar.Text);
                EkleKomut.Parameters.AddWithValue("@Tel", maskTxtTel.Text);
                EkleKomut.Parameters.AddWithValue("@Adres", txtAdres.Text.ToUpper());
                EkleKomut.Parameters.AddWithValue("@EPosta", txtEPosta.Text);
                EkleKomut.Parameters.AddWithValue("@BayiID", Convert.ToInt32(cmbPersBayi.SelectedValue));
                EkleKomut.Parameters.AddWithValue("@Sifre",PersSıfre);


                if (EkleKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " " + "İsimli Kayıt Ekledi!");
                }

                AnaMenuForm.con.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
            }
        }

        public void BayiDoldur()
        {
            try
            {
                string Sorgu = "Select *From Bayi";
                SqlCommand Doldur = new SqlCommand(Sorgu, AnaMenuForm.con);
                Doldur.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Doldur;
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmbPersBayi.DataSource = ds.Tables[0];
                cmbPersBayi.DisplayMember = "BayiAdi";
                cmbPersBayi.ValueMember = "BayiID";

            }

            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "MarkaDoldur Error");
            }
        }
        public bool BoslukKontrol()
        {

            bool bos = false;  //Tüm alanlar dolu


            txtEPosta.BackColor = Color.AntiqueWhite;
            txtAdres.BackColor = Color.AntiqueWhite;
            maskTxtTel.BackColor = Color.AntiqueWhite;
            cmbDYer.BackColor = Color.AntiqueWhite;
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

            if (cmbDYer.Text == "")
            {
                cmbDYer.BackColor = Color.Red;
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
            SqlCommand tekrar = new SqlCommand("select count(*) from Personel where TcNo='" + maskTxtTc.Text + "'", AnaMenuForm.con);
            int sonuc = (int)tekrar.ExecuteScalar();
            if (sonuc == 0)
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
                frm.btnKayitListele.PerformClick();
            }
            }
            else if (sonuc > 0)
            {
                MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " " + "İsimli Kayıt Zaten Var!");
                AnaMenuForm.con.Close();

            }
        }

        private void PersonelKayitEkleForm_Load(object sender, EventArgs e)
        {
            BayiDoldur();
        }
    }
}
