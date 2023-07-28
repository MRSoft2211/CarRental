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
    public partial class AracKiralaForm : Form
    {
        

        public AracKiralaForm()
        {
            InitializeComponent();
        }

        public void MusterListele()
        {
            try
            {
                AnaMenuForm.con.Open();
                DataSet ds = new DataSet();
                string SorguListele = "Select *from Musteri";
                SqlDataAdapter da = new SqlDataAdapter(SorguListele, AnaMenuForm.con);
                da.Fill(ds, "Musteri");
                DataTable dTable = new DataTable();
                AracKiralaForm frmKirala = (AracKiralaForm)Application.OpenForms["AracKiralaForm"];
                frmKirala.dataGridMusteri.DataSource = ds.Tables["Musteri"];
                AnaMenuForm.con.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayit Listele Hata Penceresi");
            }
        }

        public void AracListele()
        {
            try
            {
                AnaMenuForm.con.Open();
                DataSet ds = new DataSet();
                string aracListele = "Select *from aracTanimla where BayiID=" + AnaMenuForm.PersBayiID + "And aracDurum='Uygun'";
                SqlDataAdapter da = new SqlDataAdapter(aracListele, AnaMenuForm.con);
                da.Fill(ds, "aracTanimla");
                DataTable dTable = new DataTable(aracListele);
                AracKiralaForm frmKirala = (AracKiralaForm)Application.OpenForms["AracKiralaForm"];
                frmKirala.dataGridArac.DataSource = ds.Tables["aracTanimla"];
                AnaMenuForm.con.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Araçlar Listelenemedi !");

            }
        }
        


        private void AracKiralaForm_Load(object sender, EventArgs e)
        {


            dataGridMusteri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridMusteri.DatagridviewTasarim();
            MusterListele();

            try
            {
                dataGridMusteri.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridMusteri.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridMusteri.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridMusteri.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridMusteri.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridMusteri.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridMusteri.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridMusteri.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;






            }
            catch (Exception Hata)
            {


            }

            AracListele();
          
           

            dataGridArac.DatagridviewTasarimDegistir();

            dtBaslangıc.CustomFormat = "d/M/yyyy HH:mm:ss";
            dtBitis.CustomFormat = "d/M/yyyy HH:mm:ss";
        }
        public int GunFarkiBul(DateTime dt1, DateTime dt2)

        {

            TimeSpan zaman = new TimeSpan(); // zaman farkını bulmak adına kullanılacak olan nesne
            int num =1;
            zaman = dt2 - dt1;//metoda gelen 2 tarih arasındaki fark
           
           
            return Math.Abs(zaman.Days)+num; // 2 tarih arasındaki farkın kaç gün olduğu döndürülüyor.

        }


        private void btnAraçTeslimEt_Click(object sender, EventArgs e)
        {
           
            string MusteriAd = Convert.ToString(dataGridMusteri.CurrentRow.Cells["MusteriAd"].Value);
            string AracModel = Convert.ToString(dataGridArac.CurrentRow.Cells["AracModel"].Value);
            string GunlukFıyat = Convert.ToString(dataGridArac.CurrentRow.Cells["AracGunlukFiyat"].Value);


            DateTime dt1 = new DateTime(); // 2 tane tarih girişi için üretilen TarihZaman nesneleri

            DateTime dt2 = new DateTime();

            dt1 = dtBitis.Value; // takvimde seçilen tarihler nesnelere aktarılıyor.

            dt2 = dtBaslangıc.Value;

            string kiraGün = GunFarkiBul(dt1, dt2).ToString(); //textbox'a da çağrılan metod yardımıyla
            double kiralamaBedeli = Convert.ToInt32(kiraGün) * Convert.ToDouble(GunlukFıyat) ;

            string AracMarka = Convert.ToString(dataGridArac.CurrentRow.Cells["AracMarka"].Value);
            string MusteriSoyad = Convert.ToString(dataGridMusteri.CurrentRow.Cells["MusteriSoyad"].Value);

            string AracModelMarka = AracMarka + " " + AracModel;
            string MusteriAdSoyad = MusteriAd +" "+ MusteriSoyad;

            

            AracKiraSozlesmeForm.AracID = Convert.ToInt32(dataGridArac.CurrentRow.Cells["AracID"].Value);
            AracKiraSozlesmeForm.AracKm = Convert.ToString(dataGridArac.CurrentRow.Cells["AracKm"].Value);
            AracKiraSozlesmeForm.AracModelMarka = AracModelMarka;
            AracKiraSozlesmeForm.AracRenk = Convert.ToString(dataGridArac.CurrentRow.Cells["Aracrenk"].Value);
            AracKiraSozlesmeForm.AracPlaka = Convert.ToString(dataGridArac.CurrentRow.Cells["AracPlaka"].Value);
            AracKiraSozlesmeForm.AracVites = Convert.ToString(dataGridArac.CurrentRow.Cells["AracVites"].Value);
            AracKiraSozlesmeForm.AracYakitTipi = Convert.ToString(dataGridArac.CurrentRow.Cells["AracYakitTipi"].Value);
            AracKiraSozlesmeForm.ModelYili = Convert.ToString(dataGridArac.CurrentRow.Cells["AracModelYili"].Value);
            AracKiraSozlesmeForm.SasiNo = Convert.ToString(dataGridArac.CurrentRow.Cells["AracSasiNo"].Value);


            AracKiraSozlesmeForm.MusteriID = Convert.ToInt32(dataGridMusteri.CurrentRow.Cells["MusteriID"].Value);
            AracKiraSozlesmeForm.MusteriAdSoyad = MusteriAdSoyad;
            AracKiraSozlesmeForm.MusteriEposta = Convert.ToString(dataGridMusteri.CurrentRow.Cells["MusteriEPosta"].Value);
            AracKiraSozlesmeForm.MusteriTel = Convert.ToString(dataGridMusteri.CurrentRow.Cells["MusteriTelefon"].Value);
            AracKiraSozlesmeForm.MusteriTcNo = Convert.ToString(dataGridMusteri.CurrentRow.Cells["MusteriTcNo"].Value);

            AracKiraSozlesmeForm.KiraGunSayisi = kiraGün;
            AracKiraSozlesmeForm.GunlukFiyat = GunlukFıyat;
            AracKiraSozlesmeForm.KiralamaBedeli = Convert.ToDouble(kiralamaBedeli);
            AracKiraSozlesmeForm.BaslangıcTarih = Convert.ToString(dt2);
            AracKiraSozlesmeForm.BitisTarih = Convert.ToString(dt1);

            if (AracKiraSozlesmeForm.Control == true)
            {
                AracKiraSozlesmeForm frmSozlesme = (AracKiraSozlesmeForm)Application.OpenForms["AracKiraSozlesmeForm"];
                frmSozlesme.Close();

            }
            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
            frm.btnAracTeslimEtSozlesme.PerformClick();
            AracKiraSozlesmeForm.Control = true;
            this.Close();

           

           
        }
    }
}
