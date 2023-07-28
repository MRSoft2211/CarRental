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
    public partial class AracListeleForm : Form
    {
        public AracListeleForm()
        {
            InitializeComponent();
        }

        public static void AracListele()
        {
            try
            {
                AnaMenuForm.con.Open();
                DataSet ds = new DataSet();
                string aracListele = "Select *from aracTanimla";
                SqlDataAdapter da = new SqlDataAdapter(aracListele, AnaMenuForm.con);
                da.Fill(ds, "aracTanimla");
                DataTable dTable = new DataTable(aracListele);
                AracListeleForm frmListele = (AracListeleForm)Application.OpenForms["AracListeleForm"];
                frmListele.dataGridArac.DataSource = ds.Tables["aracTanimla"];
                AnaMenuForm.con.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Araçlar Listelenemedi !");

            }

        }

        private void AracListeleForm_Load(object sender, EventArgs e)
        {

            dataGridArac.DatagridviewTasarimDegistir();
            AracListele();
            try
            {
                dataGridArac.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridArac.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            catch (Exception)
            {


            }


        }


        private void btnGridSil_Click(object sender, EventArgs e)
        {
            if (dataGridArac.Rows.Count != 0)
            {
                AracSilForm.ID = Convert.ToInt32(dataGridArac.CurrentRow.Cells["AracID"].Value);
                AracSilForm.AracMarka = Convert.ToString(dataGridArac.CurrentRow.Cells["AracMarka"].Value);
                AracSilForm.AracModelYili = Convert.ToString(dataGridArac.CurrentRow.Cells["AracModelYili"].Value);
                AracSilForm.AracRenk = Convert.ToString(dataGridArac.CurrentRow.Cells["AracRenk"].Value);
                AracSilForm.AracPlaka = Convert.ToString(dataGridArac.CurrentRow.Cells["AracPlaka"].Value);
                AracSilForm.AracSasiNo = Convert.ToString(dataGridArac.CurrentRow.Cells["AracSasiNo"].Value);
            }

            if (AracSilForm.Control == true)
            {
                AracSilForm frmSil = (AracSilForm)Application.OpenForms["AracSilForm"];
                frmSil.Close();

            }
            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
            frm.btnAracSil.PerformClick();
            AracSilForm.Control = true;
            this.Close();
        }

        private void btnGridGuncelle_Click(object sender, EventArgs e)
        {

            if (dataGridArac.Rows.Count != 0)
            {
                AracGuncelleForm.ID = Convert.ToInt32(dataGridArac.CurrentRow.Cells["AracID"].Value);
                AracGuncelleForm.AracMarka = Convert.ToString(dataGridArac.CurrentRow.Cells["AracMarka"].Value);
                AracGuncelleForm.AracModel = Convert.ToString(dataGridArac.CurrentRow.Cells["AracModel"].Value);
                AracGuncelleForm.AracModelYili = Convert.ToString(dataGridArac.CurrentRow.Cells["AracModelYili"].Value);
                AracGuncelleForm.AracKm = Convert.ToString(dataGridArac.CurrentRow.Cells["AracKm"].Value);
                AracGuncelleForm.AracRenk = Convert.ToString(dataGridArac.CurrentRow.Cells["AracRenk"].Value);
                AracGuncelleForm.AracMotorGucu = Convert.ToString(dataGridArac.CurrentRow.Cells["AracMotorGucu"].Value);
                AracGuncelleForm.AracMotorHacmi = Convert.ToString(dataGridArac.CurrentRow.Cells["AracMotorHacmi"].Value);
                AracGuncelleForm.AracVites = Convert.ToString(dataGridArac.CurrentRow.Cells["AracVites"].Value);
                AracGuncelleForm.AracMotorGucu = Convert.ToString(dataGridArac.CurrentRow.Cells["AracMotorGucu"].Value);
                AracGuncelleForm.AracKasaTipi = Convert.ToString(dataGridArac.CurrentRow.Cells["AracKasaTipi"].Value);
                AracGuncelleForm.AracCekis = Convert.ToString(dataGridArac.CurrentRow.Cells["AracCekis"].Value);
                AracGuncelleForm.AracPlaka = Convert.ToString(dataGridArac.CurrentRow.Cells["AracPlaka"].Value);
                AracGuncelleForm.AracPaket = Convert.ToString(dataGridArac.CurrentRow.Cells["AracPaket"].Value);
                AracGuncelleForm.AracGunlukFiyat = Convert.ToString(dataGridArac.CurrentRow.Cells["AracGunlukFiyat"].Value);


            }
            if (AracGuncelleForm.Control == true)
            {
                AracGuncelleForm frmGuncelle = (AracGuncelleForm)Application.OpenForms["AracGuncelleForm"];
                frmGuncelle.Close();
            }

            AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
            frm.btnAracGuncelle.PerformClick();
            AracGuncelleForm.Control = true;
            this.Close();





        }

        private void chkModel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModel.Checked)
            {
                txtModelAra.Enabled = true;
                txtModelAra.Focus();

            }
            else
            {
                txtModelAra.Enabled = false;
                txtModelAra.Clear();
            }
        }

        private void chkPlaka_CheckedChanged(object sender, EventArgs e)
            {
                if (chkPlaka.Checked)
                {
                    txtPlakaAra.Enabled = true;
                    txtPlakaAra.Focus();

                }
                else
                {
                    txtPlakaAra.Enabled = false;
                txtPlakaAra.Clear();

                }
            }
        public void KayitAra()
        {
            try
            {
                AnaMenuForm.Baglanti();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "Select * from aracTanimla ";
                string SorguModel = "Select *from aracTanimla Where AracModel='" + txtModelAra.Text + "'";
                string SorguPlaka = "Select *from aracTanimla Where AracPlaka='" + txtPlakaAra.Text + "'";
                string sorguMdlPlk = "Select *from aracTanimla Where AracModel='" + txtModelAra.Text + "' And AracPlaka='" + txtPlakaAra.Text + "'";


                if (chkModel.Checked && chkPlaka.Checked)
                {
                    SorguTumKayitlar = sorguMdlPlk;
                }

                else if (chkModel.Checked)
                {
                    SorguTumKayitlar = SorguModel;
                }
                else if (chkPlaka.Checked)
                {
                    SorguTumKayitlar = SorguPlaka;
                }




                SqlDataAdapter da = new SqlDataAdapter(SorguTumKayitlar, AnaMenuForm.con);
                da.Fill(ds, "aractanimla");
                dataGridArac.DataSource = ds.Tables["aractanimla"];
                AnaMenuForm.con.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }
        public void HizliAra()
        {
            try
            {
                AnaMenuForm.Baglanti();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "Select *from aracTanimla ";
                string SorguSasilebaslayan = "Select *from aracTanimla where AracSasiNo Like'" + txtHizliAra.Text + "%' ";
                string SorguSasiilebiten = "Select *from aracTanimla where AracSasiNo Like'%" + txtHizliAra.Text + "' ";
                string SorguSasiiceren = "Select *from aracTanimla where AracSasiNo Like'%" + txtHizliAra.Text + "%' ";

                string SorguMdlYililebaslayan = "Select *from aracTanimla where AracModelYili Like'" + txtHizliAra.Text + "%' ";
                string SorgumdlYililebiten = "Select *from aracTanimla where AracModelYili Like'%" + txtHizliAra.Text + "' ";
                string SorguMdlYiliceren = "Select *from aracTanimla where AracModelYili Like'%" + txtHizliAra.Text + "%' ";

                string SorguMarkailebaslayan = "Select *from aracTanimla where AracMarka Like'" + txtHizliAra.Text + "%' ";
                string SorguMarkailebiten = "Select *from aracTanimla where AracMarka Like'%" + txtHizliAra.Text + "' ";
                string SorguMarkaiceren = "Select *from aracTanimla where AracMarka Like'%" + txtHizliAra.Text + "%' ";

                if (radSasiNo.Checked==true)
                {
                    if (cmbAramaTuru.Text == "ile Baslayan")
                    {
                        SorguTumKayitlar = SorguSasilebaslayan;
                    }
                    else if (cmbAramaTuru.Text == "ile Biten")
                    {
                        SorguTumKayitlar = SorguSasiilebiten;
                    }
                    else if (cmbAramaTuru.Text == "İceren")
                    {
                        SorguTumKayitlar = SorguSasiiceren;
                    }
                }

                else if (radModelYili.Checked==true)
                {

                    if (cmbAramaTuru.Text == "ile Baslayan")
                    {
                        SorguTumKayitlar = SorguMdlYililebaslayan;
                    }
                    else if (cmbAramaTuru.Text == "ile Biten")
                    {
                        SorguTumKayitlar = SorgumdlYililebiten;
                    }
                    else if (cmbAramaTuru.Text == "İceren")
                    {
                        SorguTumKayitlar = SorguMdlYiliceren;
                    }
                }

                else if (radMarka.Checked==true)
                {
                
                    if (cmbAramaTuru.Text == "ile Baslayan")
                    {
                        SorguTumKayitlar = SorguMarkailebaslayan;
                    }
                    else if (cmbAramaTuru.Text == "ile Biten")
                    {
                        SorguTumKayitlar = SorguMarkailebiten;
                    }
                    else if (cmbAramaTuru.Text == "İceren")
                    {
                        SorguTumKayitlar = SorguMarkaiceren;
                    }
                }



                SqlDataAdapter da = new SqlDataAdapter(SorguTumKayitlar, AnaMenuForm.con);
                da.Fill(ds, "aracTanimla");
                dataGridArac.DataSource = ds.Tables["aracTanimla"];
                AnaMenuForm.con.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        private void radSasiNo_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "Şasi No:";
        }

        private void radModelYili_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "Model Yılı:";

        }

        private void radMarka_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "Marka:";

        }

        private void txtHizliAra_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }
    }
}
