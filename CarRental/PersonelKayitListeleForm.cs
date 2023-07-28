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
    public partial class PersonelKayitListeleForm : Form
    {
        public PersonelKayitListeleForm()
        {
            InitializeComponent();
            this.datagridPers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static void KayitListele()
        {
            try
            {
                AnaMenuForm.con.Open();
                DataSet ds = new DataSet();
                string SorguListele = "Select *from Personel";
                SqlDataAdapter da = new SqlDataAdapter(SorguListele, AnaMenuForm.con);
                da.Fill(ds, "Personel");
                DataTable dTable = new DataTable();
                PersonelKayitListeleForm frmPersKayitListele = (PersonelKayitListeleForm)Application.OpenForms["PersonelKayitListeleForm"];
                frmPersKayitListele.datagridPers.DataSource = ds.Tables["Personel"];
                AnaMenuForm.con.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayit Listele Hata Penceresi");
            }
           
        }
        private void btnGridKayitSil_Click(object sender, EventArgs e)
        {
            if (datagridPers.Rows.Count != 0)
            {
                PersonelKayitSilForm.ID = Convert.ToInt32(datagridPers.CurrentRow.Cells["PersonelID"].Value);
                PersonelKayitSilForm.Ad = Convert.ToString(datagridPers.CurrentRow.Cells["Ad"].Value);
                PersonelKayitSilForm.Soyad = Convert.ToString(datagridPers.CurrentRow.Cells["Soyad"].Value);
                PersonelKayitSilForm.Adres = Convert.ToString(datagridPers.CurrentRow.Cells["Adres"].Value);
                PersonelKayitSilForm.Tel = Convert.ToString(datagridPers.CurrentRow.Cells["Tel"].Value);
                PersonelKayitSilForm.TcNo = Convert.ToString(datagridPers.CurrentRow.Cells["TcNo"].Value);
                PersonelKayitSilForm.EPosta = Convert.ToString(datagridPers.CurrentRow.Cells["EPosta"].Value);
            }
            if (PersonelKayitSilForm.Control == true)
            {
                PersonelKayitSilForm frmSil = (PersonelKayitSilForm)Application.OpenForms["PersonelKayitSilForm"];
                frmSil.Close();

            }

            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
            frm.btnPersKayitSil.PerformClick();
            PersonelKayitSilForm.Control = true;
            this.Close();
        }



        private void PersonelKayitListele_Load(object sender, EventArgs e)
        {
            cmbAramaTuru.Text = " ";
            datagridPers.DatagridviewTasarimDegistir();
            KayitListele();
            try
            {
                datagridPers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception )
            {

               
            }
            datagridPers.RowsDefaultCellStyle.Font = new Font("Tahoma", 12F, FontStyle.Regular);
            datagridPers.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12F, FontStyle.Regular);


        }

     
       

        private void btnGridKayitGuncelle_Click(object sender, EventArgs e)
        {
            if (datagridPers.Rows.Count != 0)
            {
                PersonelKayitGuncelleForm.ID = Convert.ToInt32(datagridPers.CurrentRow.Cells["PersonelID"].Value);
                PersonelKayitGuncelleForm.Ad = Convert.ToString(datagridPers.CurrentRow.Cells["Ad"].Value);
                PersonelKayitGuncelleForm.Soyad = Convert.ToString(datagridPers.CurrentRow.Cells["Soyad"].Value);
                PersonelKayitGuncelleForm.Adres = Convert.ToString(datagridPers.CurrentRow.Cells["Adres"].Value);
                PersonelKayitGuncelleForm.Tel = Convert.ToString(datagridPers.CurrentRow.Cells["Tel"].Value);
                PersonelKayitGuncelleForm.TcNo = Convert.ToString(datagridPers.CurrentRow.Cells["TcNo"].Value);
                PersonelKayitGuncelleForm.EPosta = Convert.ToString(datagridPers.CurrentRow.Cells["EPosta"].Value);

            }

            if (PersonelKayitGuncelleForm.Control == true)
            {
                PersonelKayitGuncelleForm frmGuncelle = (PersonelKayitGuncelleForm)Application.OpenForms["PersonelKayitGuncelleForm"];
                frmGuncelle.Close();

            }
            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
            frm.btnPersonelKayitGüncelle.PerformClick();
            PersonelKayitGuncelleForm.Control = true;
            this.Close();
        }

        private void PersonelKayitListeleForm_Activated(object sender, EventArgs e)
        {
            try
            {
                datagridPers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridPers.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception)
            {


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
        public void KayitAra()
        {
            try
            {
                AnaMenuForm.Baglanti();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "Select *from Personel ";
                string SorguAd = "Select *from Personel Where Ad" + txtAdAra.Text + "'";
                string SorguSoyad = "Select *from Personel Where Soyad='" + txtSoyadAra.Text + "'";
                string sorguAdSoyad = "Select *from Personel Where Ad='" + txtAdAra.Text + "' And Soyad='" + txtSoyadAra.Text + "'";


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
                da.Fill(ds, "Personel");
                datagridPers.DataSource = ds.Tables["Personel"];
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
                string SorguTumKayitlar = "Select *from Personel ";
                string SorguTcNoilebaslayan = "Select *from Personel where TcNo Like'" + txtHizliAra.Text + "%' ";
                string SorguTcNoilebiten = "Select *from Personel where TcNo Like'%" + txtHizliAra.Text + "' ";
                string SorguTcNoiceren = "Select *from Personel where TcNo Like'%" + txtHizliAra.Text + "%' ";

                string SorguDYerilebaslayan = "Select *from Personel where DYer Like'" + txtHizliAra.Text + "%' ";
                string SorguDYerilebiten = "Select *from Personel where DYer Like'%" + txtHizliAra.Text + "' ";
                string SorguDYericeren = "Select *from Personel where DYer Like'%" + txtHizliAra.Text + "%' ";

                string SorguDTarilebaslayan = "Select *from Personel where DTar Like'" + txtHizliAra.Text + "%' ";
                string SorguDTarilebiten = "Select *from Personel where DTar Like'%" + txtHizliAra.Text + "' ";
                string SorguDTariceren = "Select *from Personel where DTar Like'%" + txtHizliAra.Text + "%' ";

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

                else if (radDYer.Checked)
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
                da.Fill(ds, "Personel");
                datagridPers.DataSource = ds.Tables["Personel"];
                AnaMenuForm.con.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        private void radTcNo_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "TC No:";
        }

        private void radDYer_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "Doğum Yeri:";

        }

        private void radDTar_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "Doğum Tarihi:";

        }

        private void txtHizliAra_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }
    }
}
 