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
    public partial class MusteriListeleForm : Form
    {
        public static int ID;
        public static string Ad;
        public static string Soyad;
        public static string EPosta;
        public static string Tel;
        public static string TcNo;
        public static string Adres;
        public static bool Control;

        public MusteriListeleForm()
        {
            InitializeComponent();
        }

        public static void KayitListele()
        {
            try
            {
                AnaMenuForm.con.Open();
                DataSet ds = new DataSet();
                string SorguListele = "Select *from Musteri";
                SqlDataAdapter da = new SqlDataAdapter(SorguListele, AnaMenuForm.con);
                da.Fill(ds, "Musteri");
                DataTable dTable = new DataTable();
                MusteriListeleForm frmListele = (MusteriListeleForm)Application.OpenForms["MusteriListeleForm"];
                frmListele.datagridMusteri.DataSource = ds.Tables["Musteri"];
                AnaMenuForm.con.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayit Listele Hata Penceresi");
            }

        }

        private void btnGridKayitGuncelle_Click(object sender, EventArgs e)
        {
            if (datagridMusteri.Rows.Count != 0)
            {
                MusteriGuncelleForm.ID = Convert.ToInt32(datagridMusteri.CurrentRow.Cells["MusteriID"].Value);
                MusteriGuncelleForm.Ad = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriAd"].Value);
                MusteriGuncelleForm.Soyad = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriSoyad"].Value);
                MusteriGuncelleForm.Adres = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriAdres"].Value);
                MusteriGuncelleForm.Tel = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriTelefon"].Value);
                MusteriGuncelleForm.TcNo = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriTcNo"].Value);
                MusteriGuncelleForm.EPosta = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriEPosta"].Value);

            }

            if (MusteriGuncelleForm.Control == true)
            {
                MusteriGuncelleForm frmGuncelle = (MusteriGuncelleForm)Application.OpenForms["MusteriGuncelleForm"];
                frmGuncelle.Close();

            }
            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
            frm.btnMusteriGuncelle.PerformClick();
            MusteriGuncelleForm.Control = true;
            this.Close();
        }

        private void btnGridKayitSil_Click(object sender, EventArgs e)
        {
            if (datagridMusteri.Rows.Count != 0)
            {
                MusteriSilForm.ID = Convert.ToInt32(datagridMusteri.CurrentRow.Cells["MusteriID"].Value);
                MusteriSilForm.Ad = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriAd"].Value);
                MusteriSilForm.Soyad = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriSoyad"].Value);
                MusteriSilForm.Adres = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriAdres"].Value);
                MusteriSilForm.Tel = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriTelefon"].Value);
                MusteriSilForm.TcNo = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriTcNo"].Value);
                MusteriSilForm.EPosta = Convert.ToString(datagridMusteri.CurrentRow.Cells["MusteriEPosta"].Value);
            }
            if (MusteriSilForm.Control == true)
            {
                MusteriSilForm frmSil = (MusteriSilForm)Application.OpenForms["MusteriSilForm"];
                frmSil.Close();
            }

            //Ana menüdeki butona tıklama yaparak panele geçiyoruz.
            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
            frm.btnMusteriSil.PerformClick();
            MusteriSilForm.Control = true;
            this.Close();
        }

        private void MusteriListeleForm_Load(object sender, EventArgs e)
        {
            cmbAramaTuru.Text = " ";
            datagridMusteri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            datagridMusteri.DatagridviewTasarim();
            KayitListele();
            try
            {
                datagridMusteri.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridMusteri.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridMusteri.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridMusteri.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridMusteri.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridMusteri.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridMusteri.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridMusteri.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;






            }
            catch (Exception Hata)
            {


            }
          
        }

        private void chkAd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAd.Checked)
            {
                txtAdAra.Enabled = true;
                txtAdAra.Focus();

            }
            else
            {
                txtAdAra.Enabled = false;
                txtAdAra.Clear();
            }
        }
        private void chkSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoyad.Checked)
            {
                txtSoyadAra.Enabled = true;
                txtSoyadAra.Focus();

            }
            else
            {
                txtSoyadAra.Enabled = false;
                txtSoyadAra.Clear();
            }
        }

        public void KayitAra()
        {
            try
            {
                AnaMenuForm.Baglanti();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "Select * from Musteri ";
                string SorguAd = "Select *from Musteri Where MusteriAd='" + txtAdAra.Text + "'";
                string SorguSoyad = "Select *from Musteri Where MusteriSoyad='" + txtSoyadAra.Text + "'";
                string sorguAdSoyad = "Select *from Musteri Where MusteriAd='" + txtAdAra.Text + "' And MusteriSoyad='" + txtSoyadAra.Text + "'";


                if (chkAd.Checked && chkSoyad.Checked)
                {
                    SorguTumKayitlar = sorguAdSoyad;
                }
         
                else if (chkAd.Checked)
                {
                    SorguTumKayitlar = SorguAd;
                }
                else if (chkSoyad.Checked)
                {
                    SorguTumKayitlar = SorguSoyad;
                }




                SqlDataAdapter da = new SqlDataAdapter(SorguTumKayitlar, AnaMenuForm.con);
                da.Fill(ds, "Musteri");
                datagridMusteri.DataSource = ds.Tables["Musteri"];
                AnaMenuForm.con.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }


        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }
        public void HizliAra()
        {
            try
            {
                AnaMenuForm.Baglanti();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "Select *from Musteri ";
                string SorguTcNoilebaslayan = "Select *from Musteri where MusteriTcNo Like'" + txtHizliAra.Text + "%' ";
                string SorguTcNoilebiten = "Select *from Musteri where MusteriTcNo Like'%" + txtHizliAra.Text + "' ";
                string SorguTcNoiceren = "Select *from Musteri where MusteriTcNo Like'%" + txtHizliAra.Text + "%' ";

                string SorguDYerilebaslayan = "Select *from Musteri where MusteriTelefon Like'" + txtHizliAra.Text + "%' ";
                string SorguDYerilebiten = "Select *from Musteri where MusteriTelefon Like'%" + txtHizliAra.Text + "' ";
                string SorguDYericeren = "Select *from Musteri where MusteriTelefon Like'%" + txtHizliAra.Text + "%' ";

                string SorguDTarilebaslayan = "Select *from Musteri where MusteriDTar Like'" + txtHizliAra.Text + "%' ";
                string SorguDTarilebiten = "Select *from Musteri where MusteriDTar Like'%" + txtHizliAra.Text + "' ";
                string SorguDTariceren = "Select *from Musteri where MusteriDTar Like'%" + txtHizliAra.Text + "%' ";

                if (radTcNo.Checked)
                {
                    if (cmbAramaTuru.Text == "ile Baslayan")
                    {
                        SorguTumKayitlar = SorguTcNoilebaslayan;
                    }
                    else if (cmbAramaTuru.Text == "ile Biten")
                    {
                        SorguTumKayitlar = SorguTcNoilebiten;
                    }
                    else if (cmbAramaTuru.Text == "İceren")
                    {
                        SorguTumKayitlar = SorguTcNoiceren;
                    }
                }

                else if (radTel.Checked)
                {

                    if (cmbAramaTuru.Text == "ile Baslayan")
                    {
                        SorguTumKayitlar = SorguDYerilebaslayan;
                    }
                    else if (cmbAramaTuru.Text == "ile Biten")
                    {
                        SorguTumKayitlar = SorguDYerilebiten;
                    }
                    else if (cmbAramaTuru.Text == "İceren")
                    {
                        SorguTumKayitlar = SorguDYericeren;
                    }
                }

                else if (radDTar.Checked)
                {
                    if (cmbAramaTuru.Text == "ile Baslayan")
                    {
                        SorguTumKayitlar = SorguDTarilebaslayan;
                    }
                    else if (cmbAramaTuru.Text == "ile Biten")
                    {
                        SorguTumKayitlar = SorguDTarilebiten;
                    }
                    else if (cmbAramaTuru.Text == "İceren")
                    {
                        SorguTumKayitlar = SorguDTariceren;
                    }
                }



                SqlDataAdapter da = new SqlDataAdapter(SorguTumKayitlar, AnaMenuForm.con);
                da.Fill(ds, "Musteri");
                datagridMusteri.DataSource = ds.Tables["Musteri"];
                AnaMenuForm.con.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        private void txtHizliAra_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

     

        private void radTcNo_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "TC No:";

        }

        private void radDTar_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "Doğum Tarihi:";

        }

        private void radTel_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "Telefon:";
        }
    }


    public static class FormIslem1
    {
        public static void DatagridviewTasarim(this DataGridView datagridview)
        {

            //İlk sütunun gizlenmesini sağlar
            datagridview.RowHeadersVisible = false;
            //Herhangibir sütunun genişliğini o sütunda yer alan en uzun değere göre ayarlar
            // datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Datagridview border sıfırlama
            datagridview.BorderStyle = BorderStyle.None;

            //Seçilen hücrenin arkaplan rengini belirleme
            datagridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(184, 227, 226);
            //Seçilen hücrenin yazı rengini belirleme
            datagridview.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 59);
            //Cell background
            datagridview.DefaultCellStyle.BackColor = Color.FromArgb(188, 205, 227);

            //Hücredeki yazıları ortalar
            datagridview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Satırların border'ını yatay çizgi yapma          
            datagridview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            //Datagridview başlık özelliğini değiştirmeyi etkinleştirme
            datagridview.EnableHeadersVisualStyles = false;
            //Başlıktaki çizgileri kaldırma
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Başlık arkaplan rengini belirleme
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 38, 59);
            //Başlık yazi rengini belirleme
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Başlığın satır boyutunu değiştirme
            datagridview.ColumnHeadersHeight = 10;
            //Başlığın seçilen hücre başlığının arkaplan rengini belirleme
            datagridview.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(8, 188, 164);
            //Seçilen hücre başlığının yazı rengini belirleme
            datagridview.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            //Başlık yazı ortalama
            datagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Satırı tamamen seçmeyi sağlar
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Satır yüksekliğini ayarlar
            datagridview.RowTemplate.Height = 40;
            //Satır eklemeyi engeller
            datagridview.AllowUserToAddRows = false;
            //Satır silmeyi engeller
            datagridview.AllowUserToDeleteRows = false;
            //Hücrede değişiklik yapmayı engeller, sadece okunmasını sağlar
            datagridview.ReadOnly = true;
            //Satırların yeniden boyutlandırılmasını engeller
            //datagridview.AllowUserToResizeRows = false;
            //Sütunların yeniden boyutlandırılmasını engeller
            datagridview.AllowUserToResizeColumns = false;
            //   datagridview.ScrollBars = ScrollBars.Both;
            //Başlık yazı ayarları
            //    datagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9F, FontStyle.Regular);
            datagridview.RowsDefaultCellStyle.Font = new Font("Tahoma", 12F, FontStyle.Regular);
            datagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12F, FontStyle.Regular);

        }
    }
}
