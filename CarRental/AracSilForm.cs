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
    public partial class AracSilForm : Form
    {
        public static int ID;
        public static string AracMarka;
        public static string AracModel;
        public static string AracModelYili;
        public static string AracKm;
        public static string AracRenk;
        public static string AracMotorGucu;
        public static string AracMotorHacmi;
        public static string AracVites;
        public static string AracKasaTipi;
        public static string AracCekis;
        public static string AracYakitTipi;
        public static string AracPlaka;
        public static string AracPaket;
        public static string AracVersiyon;
        public static string AracSasiNo;
        public static bool Control = false;
                   
                   




        public AracSilForm()
        {
            InitializeComponent();
        }

        public void AracSİl()
        {
            try

            {
                if (ID != 0)
                {

                    AnaMenuForm.Baglanti();
                    string Sorgu = "Delete from aracTanimla Where AracID=" + ID;
                    SqlCommand silkomut = new SqlCommand(Sorgu, AnaMenuForm.con);
                    if (silkomut.ExecuteNonQuery() == 1)
                        MessageBox.Show(ID + " " + "ID numaralı Kayıt Silindi");
                    AnaMenuForm.con.Close();
                }

            }


            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Silme Hata Penceresi");

            }
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtID.Text + " " + "ID numaralı araç silinecek \nOnaylıyor musunuz?", "Dikkat",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
            {
                AracSİl();
             

                AracSilForm.Control = true;
                AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                frm.btnAracListele.PerformClick();

            }
            else
            {
                MessageBox.Show("Kayıt silme işlemi iptal edildi");
                AracSilForm.Control = true;
                AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                frm.btnAracListele.PerformClick();
            }
        }

        private void AracSilForm_Load(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                txtID.Text = ID.ToString();
                txtMarka.Text = AracMarka;
                maskTxtAracModelYili.Text = AracModelYili;
                txtRenk.Text = AracRenk;
                txtPlaka.Text = AracPlaka;
                txtSasiNo.Text = AracSasiNo;

            }
     
    }
    }
}
