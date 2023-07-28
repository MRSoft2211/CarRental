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
    public partial class AracKiraSozlesmeForm : Form
    {
        public static int AracID;
        public static string AracModelMarka;
        public static string AracKm;
        public static string ModelYili;
        public static string AracRenk;
        public static string AracVites;
        public static string SasiNo;
        public static string AracPlaka;
        public static string AracYakitTipi;

        public static int MusteriID;
        public static string MusteriAdSoyad;
        public static string MusteriTel;
        public static string MusteriEposta;
        public static string MusteriTcNo;

        public static string GunlukFiyat;
        public static string KiraGunSayisi ;
        public static double KiralamaBedeli;
        public static string BaslangıcTarih;
        public static string BitisTarih;

        public static bool Control = false;


        public AracKiraSozlesmeForm()
        {
            InitializeComponent();
        }


        private void AracKiraSozlesmeForm_Load(object sender, EventArgs e)
        {

            txtAracModel.Text = AracModelMarka;
            txtAracKm.Text = AracKm;
            txtAracModelYili.Text  = ModelYili;
            txtAracRenk.Text  = AracRenk;
            txtAracVites.Text = AracVites;
            txtAracSasiNo.Text = SasiNo;
            txtAracPlaka.Text = AracPlaka;
            txtAracYakıtTipi.Text = AracYakitTipi;

            txtAdSoyad.Text = MusteriAdSoyad;
            txtTel.Text = MusteriTel;
            txtEPosta.Text = MusteriEposta;
            txtTcNo.Text = MusteriTcNo;

            txtAracGunlukFiyat.Text = GunlukFiyat;
            txtKiraGunSayisi.Text = KiraGunSayisi;
            txtKiralamBedeli.Text = Convert.ToString(KiralamaBedeli); 
            txtBaslangıcTarih.Text = BaslangıcTarih;
            txtBitisTarih.Text = BitisTarih;

           

                
        }

        private void btnKiralamaBaslat_Click(object sender, EventArgs e)
        {
            if (checkSozlesmeKabul.Checked==true)
            {
                try
                {
                    AnaMenuForm.Baglanti();
                    string Sorgu = "Insert Into aracKirala (KiraAracID,MusteriID,PersonelAdi,KiraTarih,TeslimEdilenBayi,TeslimTarih,KiraDurum,KiralamaBedeli,OdemeDurum)" +
                        "Values(@KiraAracID,@MusteriID,@PersonelAdi,@KiraTarih,@TeslimEdilenBayi,@TeslimTarih,@KiraDurum,@KiralamaBedeli,@OdemeDurum)";
                    SqlCommand EkleKomut = new SqlCommand(Sorgu, AnaMenuForm.con);
                    EkleKomut.Parameters.AddWithValue("@KiraAracID", AracID);
                    EkleKomut.Parameters.AddWithValue("@MusteriID", MusteriID);
                    EkleKomut.Parameters.AddWithValue("@PersonelAdi", AnaMenuForm.PersAdi);
                    EkleKomut.Parameters.AddWithValue("@KiraTarih", BaslangıcTarih);
                    EkleKomut.Parameters.AddWithValue("@TeslimEdilenBayi", AnaMenuForm.PersBayiID);
                    EkleKomut.Parameters.AddWithValue("@TeslimTarih", BitisTarih);
                    EkleKomut.Parameters.AddWithValue("@KiraDurum", "Kirada");
                    EkleKomut.Parameters.AddWithValue("@KiralamaBedeli", KiralamaBedeli);
                    EkleKomut.Parameters.AddWithValue("@OdemeDurum", "Ödenmedi");


                    if (EkleKomut.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(AracModelMarka + " " + "Model Araç" + " " + MusteriAdSoyad + " " + " Adlı Kişiye Kiralandı!");

                        string Sorgu2 = "Update aracTanimla Set AracDurum=@AracDurum  Where AracID =" + AracID;

                        SqlCommand GuncelleKomut = new SqlCommand(Sorgu2, AnaMenuForm.con);
                        GuncelleKomut.Parameters.AddWithValue("@AracDurum", "Kirada");

                        if (GuncelleKomut.ExecuteNonQuery() == 1)
                        {
                            AnaMenuForm.con.Close();
                            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                            frm.btnKiradaSozlesme.PerformClick();



                        }

                    }

                    AnaMenuForm.con.Close();

                }
                catch (Exception Hata)
                {
                    MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
                }
            }
            else
            {
                MessageBox.Show("Sözleşme kabul edilmedi!");
            }
            



        }

        private void btnKiralamaİptal_Click(object sender, EventArgs e)
        {
      
            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
            frm.btnAracTeslimEt.PerformClick();

        }
    }
}
