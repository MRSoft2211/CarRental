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
    public partial class AracEkleForm : Form
    {
        public AracEkleForm()
        {
            InitializeComponent();
        }

        public void markaEkle()
        {
            try
            {
                AnaMenuForm.Baglanti();
                string Sorgu = "Insert Into aracMarka (MarkaAdi)" +
                    "Values(@MarkaAdi)";
                SqlCommand markaEkle = new SqlCommand(Sorgu, AnaMenuForm.con);
                markaEkle.Parameters.AddWithValue("@MarkaAdi", txtMarkaEkle.Text);
              

                if (markaEkle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtMarkaEkle.Text+" "+ "Markalı Araç Eklendi!");
                }

                AnaMenuForm.con.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
            }
        }

        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            AnaMenuForm.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from aracMarka where MarkaAdi='" + txtMarkaEkle.Text + "'", AnaMenuForm.con);
            int sonuc = (int)tekrar.ExecuteScalar();
            if (sonuc == 0)
            {
                AnaMenuForm.con.Close();
                markaEkle();

            }
            else if (sonuc > 0)
            {
                MessageBox.Show(txtMarkaEkle.Text + " " + "isimli Kayıt Zaten Var!");
                AnaMenuForm.con.Close();

            }
            MarkaDoldur();
        }

        public void MarkaDoldur()
        {
            try
            {
                string Sorgu = "Select *From aracMarka";
                SqlCommand Doldur = new SqlCommand(Sorgu, AnaMenuForm.con);
                Doldur.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Doldur;
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmbMarkaEkle.DataSource = ds.Tables[0];
                cmbMarkaEkle.DisplayMember = "MarkaAdi";
                cmbMarkaEkle.ValueMember = "MarkaID";

            }

            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "MarkaDoldur Error");
            }
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            AnaMenuForm.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from aracModel where ModelAdi='" + txtModelEkle.Text + "'", AnaMenuForm.con);
            int sonuc = (int)tekrar.ExecuteScalar();
            if (sonuc==0)
            {
                AnaMenuForm.con.Close();
                modelEkle();

            }
            else if (sonuc>0)
            {
                MessageBox.Show(txtModelEkle.Text + " " + "isimli Kayıt Zaten Var!");
                AnaMenuForm.con.Close();

            }


        }

        private void AracEkleForm_Load(object sender, EventArgs e)
        {
            MarkaDoldur();
          
        }

        public void modelEkle() 
        {
            try
            {
                int MarkaID = Convert.ToInt32(cmbMarkaEkle.SelectedValue);
                AnaMenuForm.Baglanti();
                string Sorgu = "Insert Into aracModel (ModelAdi,ModelMarkaID)" +
                    "Values(@ModelAdi,@ModelMarkaID)";
                SqlCommand modelEkle = new SqlCommand(Sorgu, AnaMenuForm.con);
                modelEkle.Parameters.AddWithValue("@ModelAdi", txtModelEkle.Text);
                modelEkle.Parameters.AddWithValue("@ModelMarkaID", MarkaID);
            


                if (modelEkle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtModelEkle.Text+" "+" Model Eklendi!");
                }

                AnaMenuForm.con.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void modelDoldur() 
        {
            try
            {
                int MarkaID = Convert.ToInt32(cmbMarkaEkle.SelectedValue);

                string Sorgu = "Select *From aracModel Where ModelMarkaID=" + MarkaID.ToString();
                SqlCommand Doldur = new SqlCommand(Sorgu, AnaMenuForm.con);
                Doldur.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Doldur;
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmbModelDoldur.DataSource = ds.Tables[0];
                cmbModelDoldur.DisplayMember = "ModelAdi";
                cmbModelDoldur.ValueMember = "ModelID";


            }

            catch (Exception Hata)
            {
                //MessageBox.Show(Hata.Message, "Model Doldur Selected Error");

            }
        }

        private void cmbMarkaEkle_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelDoldur();
        }
        
        public void PaketEkle() 
        {
            try
            {
                int ModelID = Convert.ToInt32(cmbModelDoldur.SelectedValue);
                AnaMenuForm.Baglanti();
                string Sorgu = "Insert Into aracPaket (PaketAdi,PaketModelID)" +
                    "Values(@PaketAdi,@PaketModelID)";
                SqlCommand paketEkle = new SqlCommand(Sorgu, AnaMenuForm.con);
                paketEkle.Parameters.AddWithValue("@PaketAdi", txtPaketEkle.Text);
                paketEkle.Parameters.AddWithValue("@PaketModelID", ModelID);



                if (paketEkle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Eklendi!");
                }

                AnaMenuForm.con.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
            }
        }
    
        
        private void btnPaketEkle_Click(object sender, EventArgs e)
        {
            AnaMenuForm.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from aracPaket where PaketAdi='" + txtPaketEkle.Text + "'", AnaMenuForm.con);
            int sonuc = (int)tekrar.ExecuteScalar();
            if (sonuc == 0)
            {
                AnaMenuForm.con.Close();
                PaketEkle();
            }
            else if (sonuc > 0)
            {
                MessageBox.Show(txtPaketEkle.Text + " " + "isimli Kayıt Zaten Var!");
                AnaMenuForm.con.Close();

            }
        }
    }
}
