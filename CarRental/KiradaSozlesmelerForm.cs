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
    public partial class KiradaSozlesmelerForm : Form
    {
        public KiradaSozlesmelerForm()
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
                                  " left outer join aracTanimla on aracKirala.KiraAracID=aracTanimla.AracID  Where KiraDurum='Kirada'" +
                                  "";
                SqlDataAdapter da = new SqlDataAdapter(aracListele, AnaMenuForm.con);
                da.Fill(ds, "aracKirala");
                DataTable dTable = new DataTable(aracListele);
                KiradaSozlesmelerForm frm = (KiradaSozlesmelerForm)Application.OpenForms["KiradaSozlesmelerForm"];
                frm.dataGridKiraSozlesme.DataSource = ds.Tables["aracKirala"];
                AnaMenuForm.con.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Sözleşmeler Listelenemedi !");

            }


        }

        private void KiradaSozlesmelerForm_Load(object sender, EventArgs e)
        {
            try
            {
            //    dataGridKiraSozlesme.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dataGridKiraSozlesme.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception)
            {

              
            }
           
            dataGridKiraSozlesme.DatagridviewTasarimDegistir();
            SozlesmeListele();
        }

        private void KiradaSozlesmelerForm_Activated(object sender, EventArgs e)
        {
            try
            {
                //dataGridKiraSozlesme.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridKiraSozlesme.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception)
            {


            }

        }
    }
}
