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
    public partial class AracTeslimAlForm : Form
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

        public static int KiraID;
        public static double KiralamaBedeli;
        public static string BaslangıcTarih;
        public static string BitisTarih;

        public static bool Control = false;

        public AracTeslimAlForm()
        {
            InitializeComponent();
            lblTeslimAlınanTarih.Text = DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToLongTimeString();
        }

        private void AracTeslimAlForm_Load(object sender, EventArgs e)
        {
            txtAracModel.Text = AracModelMarka;
            txtAracKm.Text = AracKm;
            txtAracModelYili.Text = ModelYili;
            txtAracRenk.Text = AracRenk;
            txtAracVites.Text = AracVites;
            txtAracSasiNo.Text = SasiNo;
            txtAracPlaka.Text = AracPlaka;
            txtAracYakıtTipi.Text = AracYakitTipi;

            txtAdSoyad.Text = MusteriAdSoyad;
            txtTel.Text = MusteriTel;
            txtEPosta.Text = MusteriEposta;
            txtTcNo.Text = MusteriTcNo;

            txtKiralamBedeli.Text = Convert.ToString(KiralamaBedeli);
            txtBaslangıcTarih.Text = BaslangıcTarih;
            txtBitisTarih.Text = BitisTarih;
        }

        public void KiraBitir()
        {
            AnaMenuForm.Baglanti();
            string Sorgu = "Update aracKirala Set KiraDurum=@KiraDurum,TeslimAlinanBayi=@TeslimAlinanBayi  Where AracKiralaID="+KiraID;

            string Sorgu2 = "Update aracTanimla Set AracDurum=@AracDurum,AracKm=@AracKm  Where AracID=" + AracID;



            SqlCommand GuncelleKomut = new SqlCommand(Sorgu, AnaMenuForm.con);
            SqlCommand GuncelleKomut2 = new SqlCommand(Sorgu2, AnaMenuForm.con);


            GuncelleKomut.Parameters.AddWithValue("@KiraDurum", "Tamamlandı");
            GuncelleKomut.Parameters.AddWithValue("@TeslimAlinanBayi", AnaMenuForm.PersBayiID);

            GuncelleKomut2.Parameters.AddWithValue("@AracDurum", cmbAracDurum.Text);
            GuncelleKomut2.Parameters.AddWithValue("@AracKm", txtTeslimAlKm.Text);


            if (GuncelleKomut.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kiralama Tamamlandı\nAraç Teslim Alındı!");
                
            }

            if (GuncelleKomut2.ExecuteNonQuery() == 1)
            {
                AnaMenuForm.con.Close();
                this.Close();
                AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                frm.btnAracTeslimEt.PerformClick();
            }
            
        }

        private void btnKiralamaSonlandir_Click(object sender, EventArgs e)
        {
            KiraBitir();
            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
            frm.btnOdeme.PerformClick();

        }
    }

}
