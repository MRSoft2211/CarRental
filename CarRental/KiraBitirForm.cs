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
    public partial class KiraBitirForm : Form
    {

        public KiraBitirForm()
        {
            InitializeComponent();
        }
        public static void KiraListele()
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
                                  "Kiratarih as 'Kira Başlangıç',TeslimTarih as 'Kira Bitiş',KiralamaBedeli as 'Kiralama Bedeli'"+
                                  " from aracKirala" +
                                  " left outer join Musteri on aracKirala.MusteriID=Musteri.MusteriID " +
                                  " left outer join aracTanimla on aracKirala.KiraAracID=aracTanimla.AracID  Where KiraDurum='Kirada'" +
                                  "";
                SqlDataAdapter da = new SqlDataAdapter(aracListele, AnaMenuForm.con);
                da.Fill(ds, "aracKirala");
                DataTable dTable = new DataTable(aracListele);
                KiraBitirForm frmBitir = (KiraBitirForm)Application.OpenForms["KiraBitirForm"];
                frmBitir.dataGridKiraBitir.DataSource = ds.Tables["aracKirala"];
                AnaMenuForm.con.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Araçlar Listelenemedi !");

            }

        }
        public void DataGridColumn()
        {
            try
            {
                dataGridKiraBitir.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridKiraBitir.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            }
            catch (Exception)
            {

                
            }
        }

        

        private void KiraBitirForm_Load(object sender, EventArgs e)
        {
            KiraListele();
            dataGridKiraBitir.DatagridviewTasarimDegistir();
            DataGridColumn();
            
        }

        private void btnKiralamaSonlandır_Click(object sender, EventArgs e)
        {
            try
            {
                string MusteriAd = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Müşteri Ad"].Value);
                string MusteriSoyad = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Müşteri Soyad"].Value);



                string AracMarka = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Araç Marka"].Value);
                string AracModel = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Araç Model"].Value);


                string AracModelMarka = AracMarka + " " + AracModel;
                string MusteriAdSoyad = MusteriAd + " " + MusteriSoyad;

                AracTeslimAlForm.KiraID = Convert.ToInt32(dataGridKiraBitir.CurrentRow.Cells["Kira Kodu"].Value);
                AracTeslimAlForm.AracID = Convert.ToInt32(dataGridKiraBitir.CurrentRow.Cells["Araç Kodu"].Value);
                AracTeslimAlForm.AracKm = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Araç Km"].Value);
                AracTeslimAlForm.AracModelMarka = AracModelMarka;
                AracTeslimAlForm.AracRenk = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["AraÇ Renk"].Value);
                AracTeslimAlForm.AracPlaka = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Araç Plaka"].Value);
                AracTeslimAlForm.AracVites = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Araç Vites"].Value);
                AracTeslimAlForm.AracYakitTipi = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Araç Yakıt Tipi"].Value);
                AracTeslimAlForm.ModelYili = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Araç Model Yılı"].Value);
                AracTeslimAlForm.SasiNo = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Araç Şasi No"].Value);

                AracTeslimAlForm.MusteriAdSoyad = MusteriAdSoyad;
                AracTeslimAlForm.MusteriEposta = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Müşteri E-Posta"].Value);
                AracTeslimAlForm.MusteriTel = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Müşteri Telefon"].Value);
                AracTeslimAlForm.MusteriTcNo = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Müşteri Tc No"].Value);



                AracTeslimAlForm.KiralamaBedeli = Convert.ToDouble(dataGridKiraBitir.CurrentRow.Cells["Kiralama Bedeli"].Value);
                AracTeslimAlForm.BaslangıcTarih = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Kira Başlangıç"].Value);
                AracTeslimAlForm.BitisTarih = Convert.ToString(dataGridKiraBitir.CurrentRow.Cells["Kira Bitiş"].Value); ;

                if (AracTeslimAlForm.Control == true)
                {
                    AracTeslimAlForm frmSozlesme = (AracTeslimAlForm)Application.OpenForms["AracTeslimAlForm"];
                    frmSozlesme.Close();

                }
                AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                frm.btnAracTeslimAlSozlesme.PerformClick();
                AracKiraSozlesmeForm.Control = true;
                this.Close();

            }
            catch (Exception)
            {

            }
        

        }
    }
}
