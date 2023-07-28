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
    public partial class OdemeForm : Form
    {
        public static string KiraID;
        public static string AracID;
        public static bool odemeAlimDurum = false;

        public static bool Control = false;
        public OdemeForm()
        {
            InitializeComponent();
            
        }

        public static void SozlesmeListele()
        {
            try
            {
                AnaMenuForm.con.Open();
                DataSet ds = new DataSet();
                string aracListele = " select AracKiralaID as 'Kira Kodu', AracID as 'Araç Kodu', " +
                                  " MusteriAd as 'Müşteri Ad', MusteriSoyad as 'Müşteri Soyad', AracPlaka as 'Araç Plaka', AracMarka as 'Araç Marka' ," +
                                  " AracModel as 'Araç Model', AracGunlukFiyat as 'Araç Günlük Fiyat', AracKm as 'Araç Km',Ar" +
                                  "acRenk as 'Araç Renk', AracVites as 'Araç Vites',AracModelYiLi as 'Araç Model Yılı'," +
                                  "AracYakitTipi as 'Araç Yakıt Tipi',AracSasiNo as 'Araç Şasi No'," +
                                  " MusteriTcNo as 'Müşteri Tc No', MusteriEPosta as 'Müşteri E-Posta', MusteriTelefon as 'Müşteri Telefon'," +
                                  "Kiratarih as 'Kira Başlangıç',TeslimTarih as 'Kira Bitiş',KiralamaBedeli as 'Kiralama Bedeli', OdemeDurum as 'Ödeme Durum'" +
                                  " from aracKirala" +
                                  " left outer join Musteri on aracKirala.MusteriID=Musteri.MusteriID " +
                                  " left outer join aracTanimla on aracKirala.KiraAracID=aracTanimla.AracID  where OdemeDurum='Ödenmedi'" +
                                  "";
                SqlDataAdapter da = new SqlDataAdapter(aracListele, AnaMenuForm.con);
                da.Fill(ds, "aracKirala");
                DataTable dTable = new DataTable(aracListele);
                OdemeForm frmBitir = (OdemeForm)Application.OpenForms["OdemeForm"];
                frmBitir.dataGridodeme.DataSource = ds.Tables["aracKirala"];
                AnaMenuForm.con.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Sözleşmeler Listelenemedi !");

            }
          
        }

        
        private void OdemeForm_Load(object sender, EventArgs e)
        {
            
            dataGridodeme.DatagridviewTasarimDegistir();
            SozlesmeListele();
        

        }
       



        private void dataGridodeme_SelectionChanged(object sender, EventArgs e)
        {
            
            txtAracMarka.Text= dataGridodeme.CurrentRow.Cells[6].Value.ToString();
            txtAracModel.Text= dataGridodeme.CurrentRow.Cells[5].Value.ToString(); 
            txtAdSoyad.Text= dataGridodeme.CurrentRow.Cells[2].Value.ToString(); 
            txtSoyad.Text= dataGridodeme.CurrentRow.Cells[3].Value.ToString(); ;
            txtAracKm.Text = dataGridodeme.CurrentRow.Cells[8].Value.ToString();
            txtAracSasiNo.Text = dataGridodeme.CurrentRow.Cells[13].Value.ToString();
            txtAracPlaka.Text = dataGridodeme.CurrentRow.Cells[4].Value.ToString();
            txtTel.Text = dataGridodeme.CurrentRow.Cells[16].Value.ToString();
            txtTcNo.Text = dataGridodeme.CurrentRow.Cells[14].Value.ToString();
            txtKiralamBedeli.Text = dataGridodeme.CurrentRow.Cells[19].Value.ToString();
            txtBaslangıcTarih.Text = dataGridodeme.CurrentRow.Cells[17].Value.ToString();
            txtBitisTarih.Text = dataGridodeme.CurrentRow.Cells[18].Value.ToString();
            KiraID= dataGridodeme.CurrentRow.Cells[0].Value.ToString();
            

        }
        public void OdemeAl()

        {
            AnaMenuForm.Baglanti();
            string Sorgu = "Update aracKirala Set OdemeDurum=@OdemeDurum Where AracKiralaID=" + KiraID;
            SqlCommand GuncelleKomut = new SqlCommand(Sorgu, AnaMenuForm.con);


            GuncelleKomut.Parameters.AddWithValue("@OdemeDurum", "Ödendi");




            if (GuncelleKomut.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ödeme Alındı!");

            }

            AnaMenuForm.con.Close();

        }
        private void msktxtAlinanPara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                odemeAlimDurum = false;
                double Alinan = Convert.ToDouble(msktxtAlinanPara.Text);
                double SiparisTutar = Convert.ToDouble(dataGridodeme.CurrentRow.Cells[19].Value.ToString());
                double paraUstu = Alinan - SiparisTutar;
                txtParaUstu.Text = Convert.ToString(paraUstu);

                if (Alinan >= SiparisTutar)
                {
                    odemeAlimDurum = true;
                }
               
            }
            catch (Exception)
            {

            }
        }
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (odemeAlimDurum==true)
            {
                OdemeAl();
                msktxtAlinanPara.Clear();
                txtParaUstu.Clear();
                SozlesmeListele();
                AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                frm.btnAracTeslimAl.PerformClick();
            }
            else
            {
                MessageBox.Show("Eksik Ödeme, Ödeme Alınamadı!","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
        public  void MusteriAra()
        {
            try
            {
                AnaMenuForm.con.Open();
                DataSet ds = new DataSet();
                string aracListele = " select AracKiralaID as 'Kira Kodu', AracID as 'Araç Kodu', " +
                                  " MusteriAd as 'Müşteri Ad', MusteriSoyad as 'Müşteri Soyad', AracPlaka as 'Araç Plaka', AracMarka as 'Araç Marka' ," +
                                  " AracModel as 'Araç Model', AracGunlukFiyat as 'Araç Günlük Fiyat', AracKm as 'Araç Km',Ar" +
                                  "acRenk as 'Araç Renk', AracVites as 'Araç Vites',AracModelYiLi as 'Araç Model Yılı'," +
                                  "AracYakitTipi as 'Araç Yakıt Tipi',AracSasiNo as 'Araç Şasi No'," +
                                  " MusteriTcNo as 'Müşteri Tc No', MusteriEPosta as 'Müşteri E-Posta', MusteriTelefon as 'Müşteri Telefon'," +
                                  "Kiratarih as 'Kira Başlangıç',TeslimTarih as 'Kira Bitiş',KiralamaBedeli as 'Kiralama Bedeli', OdemeDurum as 'Ödeme Durum'" +
                                  " from aracKirala" +
                                  " left outer join Musteri on aracKirala.MusteriID=Musteri.MusteriID " +
                                  " left outer join aracTanimla on aracKirala.KiraAracID=aracTanimla.AracID  where MusteriAd Like'" + txtAdAra.Text+ "%' AND OdemeDurum='Ödenmedi' "; 
                                  
                SqlDataAdapter da = new SqlDataAdapter(aracListele, AnaMenuForm.con);
                da.Fill(ds, "aracKirala");
                DataTable dTable = new DataTable(aracListele);
                OdemeForm frmBitir = (OdemeForm)Application.OpenForms["OdemeForm"];
                frmBitir.dataGridodeme.DataSource = ds.Tables["aracKirala"];
                AnaMenuForm.con.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, " Müşteri Arama Hata !");

            }


        }

        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            MusteriAra();
        }
    }
}
