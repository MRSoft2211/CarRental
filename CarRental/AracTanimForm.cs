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
    public partial class AracTanimForm : Form
    {
        public AracTanimForm()
        {
            InitializeComponent();
        }

        //private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cmbPaket.Items.Clear();
        //    cmbModel.Items.Clear();
        //    if (cmbMarka.SelectedItem == "Audi") 
        //    {

        //        String[] AracModel = { "A3", "A5", "A6", "A7", "A8", "Q Serisi"};
        //        cmbModel.Items.AddRange(AracModel);

        //        String[] AracPaket = { "Standart" };
        //        cmbPaket.Items.AddRange(AracPaket);
        //    }

        //    else if (cmbMarka.SelectedItem == "BMW")
        //    {
        //        String[] AracModel = { "1 Serisi", "3 Serisi", "5 Serisi",  "M Serisi" ,"X Serisi" };
        //        cmbModel.Items.AddRange(AracModel);

        //        String[] AracPaket = { "Standart" ,"Premium-Line","Joy","M Joy","Prestige"};
        //        cmbPaket.Items.AddRange(AracPaket);

        //    }

        //    else if (cmbMarka.SelectedItem == "Citroen")
        //    {
        //        String[] AracModel = { "C3", "C4",  "C5", "C-Elysée" };
        //        cmbModel.Items.AddRange(AracModel);

        //        String[] AracPaket = { "Exclusive" ,"Live","Confort"};
        //        cmbPaket.Items.AddRange(AracPaket);

        //    }

        //    else if (cmbMarka.SelectedItem == "Fiat")
        //    {
        //        String[] AracModel = { "Egea Cross", "Egea", "Doblo","500L" };
        //        cmbModel.Items.AddRange(AracModel);

        //        String[] AracPaket = { "Easy","Fire Easy","Urban","Comfort" };
        //        cmbPaket.Items.AddRange(AracPaket);

        //    }

        //    else if (cmbMarka.SelectedItem == "Ford")
        //    {
        //        //String[] AracModel = { "Fiesta", "Focus", "Mondeo", "Kuga","Ranger","Mustang" };
        //        //cmbModel.Items.AddRange(AracModel);

        //        //String[] AracPaket = { "Trend-x","Style","Titanium" ,"ST Line","Vignale"};
        //        //cmbPaket.Items.AddRange(AracPaket);

        //    }

        //    else if (cmbMarka.SelectedItem == "Hyundai")
        //    {
        //        String[] AracModel = { "i10", "i20", "i30", "Elantra" ,"Tucson" };
        //        cmbModel.Items.AddRange(AracModel);

        //        String[] AracPaket = { "Style" ,"Style Plus","Comfort"};
        //        cmbPaket.Items.AddRange(AracPaket);

        //    }

        //    else if (cmbMarka.SelectedItem == "Mercedes - Benz")
        //    {
        //        String[] AracModel = { "A Serisi", "C Serisi", "E Serisi" };
        //        cmbModel.Items.AddRange(AracModel);

        //        String[] AracPaket = { "Style","AMG","BlueEfficiency Style","Exclusive","Avantgarde" };
        //        cmbPaket.Items.AddRange(AracPaket);

        //    }

        //    else if (cmbMarka.SelectedItem == "Peugeot")
        //    {
        //        String[] AracModel = {  "301", "308", "508" ,"3008","5008" };
        //        cmbModel.Items.AddRange(AracModel);

        //        String[] AracPaket = { "Active","BlueHDİ Active" ,"Comfort" };
        //        cmbPaket.Items.AddRange(AracPaket);

        //    }

        //    else if (cmbMarka.SelectedItem == "Renault")
        //    {
        //        String[] AracModel = { "Clio", "Fluence", "Megane", "Symbol","KadJar" };
        //        cmbModel.Items.AddRange(AracModel);

        //        String[] AracPaket = { "Joy" ,"Touch",""};
        //        cmbPaket.Items.AddRange(AracPaket);

        //    }

        //    else if (cmbMarka.SelectedItem == "Toyota")
        //    {
        //        String[] AracModel = { "Auris", "Corolla", "Land Cruiser", "Hilux"  };
        //        cmbModel.Items.AddRange(AracModel);
        //    }

        //    else if (cmbMarka.SelectedItem == "Wolkswagen")
        //    {
        //        String[] AracModel = { "Golf", "Jetta", "Poşet", "Tiguan" };
        //        cmbModel.Items.AddRange(AracModel);
        //    }


        //}

        //private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cmbVersiyon.Items.Clear(); 
        //    if (cmbModel.SelectedItem == "1 Serisi")
        //    {

        //        String[] AracModel = { "116d", "116i", "118i" };
        //        cmbVersiyon.Items.AddRange(AracModel);

        //    }

        //    else if (cmbModel.SelectedItem == "3 Serisi")
        //    {
        //        String[] AracModel = { "316i ", "318i", "318d", "320i", "320d" };
        //        cmbVersiyon.Items.AddRange(AracModel);
        //    }

        //    else if (cmbModel.SelectedItem == "5 Serisi")
        //    {
        //        String[] AracModel = { "520d ", "520i", "318d", "320d", "320i" };
        //        cmbVersiyon.Items.AddRange(AracModel);
        //    }

        //    else if (cmbModel.SelectedItem == "M Serisi")
        //    {
        //        String[] AracModel = { "M3", "M4", "M5"};
        //        cmbVersiyon.Items.AddRange(AracModel);
        //    }

        //    else if (cmbModel.SelectedItem == "X Serisi")
        //    {
        //        String[] AracModel = { "X3", "X5", "X6" };
        //        cmbVersiyon.Items.AddRange(AracModel);
        //    }

        //    else if (cmbModel.SelectedItem == "A Serisi")
        //    {
        //        String[] AracModel = { "A180", "A180d", "A200" };
        //        cmbVersiyon.Items.AddRange(AracModel);
        //    }

        //    else if (cmbModel.SelectedItem == "C Serisi")
        //    {
        //        String[] AracModel = { "C180 ", "C200", "C200D","C220CDI" };
        //        cmbVersiyon.Items.AddRange(AracModel);
        //    }

        //    else if (cmbModel.SelectedItem == "E Serisi")
        //    {
        //        String[] AracModel = { "E200 ", "E200d", "E250" };
        //        cmbVersiyon.Items.AddRange(AracModel);
        //    }

        //    else if (cmbModel.SelectedItem == "Q Serisi")
        //    {
        //        String[] AracModel = { "Q3 ", "Q5", "Q7" };
        //        cmbVersiyon.Items.AddRange(AracModel);
        //    }

        //}

        public void aracKayitEkle()
        {
            try
            {
                AnaMenuForm.Baglanti();
                string Sorgu = "Insert Into aracTanimla (AracMarka,AracModel,AracModelYili,AracKm,AracRenk," +
                    "AracMotorGucu,AracMotorHacmi,AracVites,AracKasaTipi,AracCekis,AracYakitTipi," +
                    "AracSasiNo,AracPaket,AracPlaka,AracGunlukFiyat,BayiID,AracDurum)" +
                    "Values(@AracMarka,@AracModel,@AracModelYili,@AracKm,@AracRenk,@AracMotorGucu," +
                    "@AracMotorHacmi,@AracVites,@AracKasaTipi,@AracCekis,@AracYakitTipi,@AracSasiNo," +
                    "@AracPaket,@AracPlaka,@AracGunlukFiyat,@BayiID,@AracDurum)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, AnaMenuForm.con);
                EkleKomut.Parameters.AddWithValue("@AracMarka", cmbMarka.Text);
                EkleKomut.Parameters.AddWithValue("@AracModel", cmbModel.Text);
                EkleKomut.Parameters.AddWithValue("@AracModelYili", maskTxtAracModelYili.Text);
                EkleKomut.Parameters.AddWithValue("@AracKm", mktxtKm.Text);
                EkleKomut.Parameters.AddWithValue("@AracRenk", cmbRenk.Text);
                EkleKomut.Parameters.AddWithValue("@AracMotorGucu", cmbMotorGucu.Text);
                EkleKomut.Parameters.AddWithValue("@AracMotorHacmi", cmbMotorHacmi.Text);
                EkleKomut.Parameters.AddWithValue("@AracVites", cmbVitesTipi.Text);
                EkleKomut.Parameters.AddWithValue("@AracKasaTipi", cmbKasaTipi.Text);
                EkleKomut.Parameters.AddWithValue("@AracCekis", cmbCekisTipi.Text);
                EkleKomut.Parameters.AddWithValue("@AracYakitTipi", cmbYakitTipi.Text);
                EkleKomut.Parameters.AddWithValue("@AracPlaka", txtPlaka.Text);
                EkleKomut.Parameters.AddWithValue("@AracPaket", cmbPaket.Text);
                EkleKomut.Parameters.AddWithValue("@AracSasiNo", txtSasiNo.Text);
                EkleKomut.Parameters.AddWithValue("@AracGunlukFiyat", txtAracGunlukFiyat.Text);
                EkleKomut.Parameters.AddWithValue("@BayiID", Convert.ToInt32(cmbAracBayi.SelectedValue));
                EkleKomut.Parameters.AddWithValue("@AracDurum", "Uygun");



                if (EkleKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(cmbMarka.Text + " " + cmbModel.Text + " " + "Araç Tanımlandı!");
                }

                AnaMenuForm.con.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Araç Tanımlanamadı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false;  //Tüm alanlar dolu


            cmbMarka.BackColor = Color.Linen;
            cmbModel.BackColor = Color.Linen;
            maskTxtAracModelYili.BackColor = Color.Linen;
            mktxtKm.BackColor = Color.Linen;
            cmbRenk.BackColor = Color.Linen;
            cmbMotorHacmi.BackColor = Color.Linen;
            cmbVitesTipi.BackColor = Color.Linen;
            cmbKasaTipi.BackColor = Color.Linen;
            cmbCekisTipi.BackColor = Color.Linen;
            cmbYakitTipi.BackColor = Color.Linen;
            txtPlaka.BackColor = Color.Linen;
            cmbPaket.BackColor = Color.Linen;
            txtSasiNo.BackColor = Color.Linen;
            cmbAracBayi.BackColor = Color.Linen;


            if (cmbAracBayi.Text == "")
            {
                cmbAracBayi.BackColor = Color.Red;
                cmbAracBayi.Focus();
                bos = true;
            }
            if (cmbCekisTipi.Text == "")
            {
                cmbCekisTipi.BackColor = Color.Red;
                cmbCekisTipi.Focus();
                bos = true;
            }
            if (cmbVitesTipi.Text == "")
            {
                cmbVitesTipi.BackColor = Color.Red;
                cmbVitesTipi.Focus();
                bos = true;
            }
            if (cmbMotorHacmi.Text == "")
            {
                cmbMotorHacmi.BackColor = Color.Red;
                cmbMotorHacmi.Focus();
                bos = true;
            }
            if (cmbMotorGucu.Text == "")
            {
                cmbMotorGucu.BackColor = Color.Red;
                cmbMotorGucu.Focus();
                bos = true;
            }
            if (txtSasiNo.Text == "")
            {
                txtSasiNo.BackColor = Color.Red;
                txtSasiNo.Focus();
                bos = true;
            }

            if (cmbYakitTipi.Text == "")
            {
                cmbYakitTipi.BackColor = Color.Red;
                cmbYakitTipi.Focus();
                bos = true;
            }

            if (maskTxtAracModelYili.Text == "" || maskTxtAracModelYili.Text.Length < 4)
            {
                maskTxtAracModelYili.BackColor = Color.Red;
                maskTxtAracModelYili.Focus();
                bos = true;
            }


            if (mktxtKm.Text == "")
            {
                mktxtKm.BackColor = Color.Red;
                mktxtKm.Focus();
                bos = true;
            }
            if (cmbKasaTipi.Text == "")
            {
                cmbKasaTipi.BackColor = Color.Red;
                cmbKasaTipi.Focus();
                bos = true;
            }
            if (cmbPaket.Text == "")
            {
                cmbPaket.BackColor = Color.Red;
                cmbPaket.Focus();
                bos = true;
            }
            if (cmbRenk.Text == "")
            {
                cmbRenk.BackColor = Color.Red;
                cmbRenk.Focus();
                bos = true;
            }


            if (cmbModel.Text == "")
            {
                cmbModel.BackColor = Color.Red;
                cmbKasaTipi.Focus();
                bos = true;
            }
            if (cmbMarka.Text == "")
            {
                cmbMarka.BackColor = Color.Red;
                cmbMarka.Focus();
                bos = true;
            }
            if (txtPlaka.Text == "")
            {
                txtPlaka.BackColor = Color.Red;
                txtPlaka.Focus();
                bos = true;
            }

            return bos;
        }


        private void btnAracKayitEkle_Click(object sender, EventArgs e)
        {
            AnaMenuForm.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from aracTanimla where AracPlaka='" + txtPlaka.Text + "'", AnaMenuForm.con);
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

                    aracKayitEkle();
                    this.Close();
                    AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                    frm.btnAracListele.PerformClick();
                }
            }
            else if (sonuc > 0)
            {
                MessageBox.Show(txtPlaka.Text + " " + "Plakalı Kayıt Zaten Var!");
                AnaMenuForm.con.Close();

            }

        }
    
 
        public void MarkaDoldur() 
        {
            try
            {
                string Sorgu = "Select *From aracMarka";
                SqlCommand Doldur = new SqlCommand(Sorgu, AnaMenuForm.con);
                Doldur.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Doldur;
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmbMarka.DataSource = ds.Tables[0];
                cmbMarka.DisplayMember = "MarkaAdi";
                cmbMarka.ValueMember = "MarkaID";

            }                

            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "MarkaDoldur Error");
            }
        }

        private void AracTanimForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int MarkaID = Convert.ToInt32(cmbMarka.SelectedValue);
              
                string Sorgu = "Select *From aracModel Where ModelMarkaID=" + MarkaID.ToString();
                SqlCommand Doldur = new SqlCommand(Sorgu, AnaMenuForm.con);
                Doldur.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Doldur;
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmbModel.DataSource = ds.Tables[0];
                cmbModel.DisplayMember = "ModelAdi";
                cmbModel.ValueMember = "ModelID";


            }

            catch (Exception Hata)
            {
                //MessageBox.Show(Hata.Message, "Marka Selected Error");

            }

           
        }
        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ModelID = Convert.ToInt32(cmbModel.SelectedValue);

                string Sorgu = "Select *From aracPaket Where PaketModelID=" + ModelID.ToString();
                SqlCommand Doldur = new SqlCommand(Sorgu, AnaMenuForm.con);
                Doldur.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Doldur;
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmbPaket.DataSource = ds.Tables[0];
                cmbPaket.DisplayMember = "PaketAdi";
                cmbPaket.ValueMember = "PaketID";


            }

            catch (Exception Hata)
            {
                //MessageBox.Show(Hata.Message, "Marka Selected Error");

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
                cmbAracBayi.DataSource = ds.Tables[0];
                cmbAracBayi.DisplayMember = "BayiAdi";
                cmbAracBayi.ValueMember = "BayiID";

            }

            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "MarkaDoldur Error");
            }
        }

     
        private void linkLblYeniArac_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AracEkleForm frmEkle = new AracEkleForm();
            frmEkle.ShowDialog();
            MarkaDoldur();
        }

        private void btnYeniAracEkle_Click(object sender, EventArgs e)
        {
            AracEkleForm frmEkle = new AracEkleForm();
            frmEkle.ShowDialog();
            MarkaDoldur();
        }

        private void cmbMarka_Click(object sender, EventArgs e)
        {
            MarkaDoldur();

        }

        private void cmbAracBayi_Click(object sender, EventArgs e)
        {
            BayiDoldur();

        }
    }
}
