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
    public partial class TamamlananSozlesmeForm : Form
    {
        public TamamlananSozlesmeForm()
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
                                  " AracModel as 'Araç Model', AracKm as 'Araç Km',AracRenk as 'Araç Renk', AracVites as 'Araç Vites',AracModelYiLi as 'Araç Model Yılı'," +
                                  "AracYakitTipi as 'Araç Yakıt Tipi',AracSasiNo as 'Araç Şasi No'," +
                                  " MusteriTcNo as 'Müşteri Tc No', MusteriEPosta as 'Müşteri E-Posta', MusteriTelefon as 'Müşteri Telefon'," +
                                  "Kiratarih as 'Kira Başlangıç',TeslimTarih as 'Kira Bitiş',KiralamaBedeli as 'Kiralama Bedeli'" +
                                  " from aracKirala" +
                                  " left outer join Musteri on aracKirala.MusteriID=Musteri.MusteriID " +
                                  " left outer join aracTanimla on aracKirala.KiraAracID=aracTanimla.AracID  Where KiraDurum='Tamamlandı'" +
                                  "";
                SqlDataAdapter da = new SqlDataAdapter(aracListele, AnaMenuForm.con);
                da.Fill(ds, "aracKirala");
                DataTable dTable = new DataTable(aracListele);
                TamamlananSozlesmeForm frmBitir = (TamamlananSozlesmeForm)Application.OpenForms["TamamlananSozlesmeForm"];
                frmBitir.dataGridBitmisKira.DataSource = ds.Tables["aracKirala"];
                AnaMenuForm.con.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Sözleşmeler Listelenemedi !");

            }

            
        }

        private void TamamlananSozlesmeForm_Load(object sender, EventArgs e)
        {
            try
            {
                //dataGridBitmisKira.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridBitmisKira.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



            }
            catch (Exception)
            {


            }
            dataGridBitmisKira.DatagridviewTasarimDegistir();
            SozlesmeListele();
        }

        private void TamamlananSozlesmeForm_Activated(object sender, EventArgs e)
        {
            try
            {
    


            }
            catch (Exception)
            {


            }

        }
    }
}
