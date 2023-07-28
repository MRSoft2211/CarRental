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
    public partial class MusteriSilForm : Form
    {
        public static int ID;
        public static string Ad;
        public static string Soyad;
        public static string EPosta;
        public static string Tel;
        public static string TcNo;
        public static string Adres;
        public static bool Control;

        public MusteriSilForm()
        {
            InitializeComponent();
        }

        public void MusteriKayitSil()
        {
            try

            {
                if (ID != 0)
                {

                    AnaMenuForm.Baglanti();
                    string Sorgu = "Delete from Musteri Where MusteriID=" + ID;
                    SqlCommand SilKomut = new SqlCommand(Sorgu, AnaMenuForm.con);
                    if (SilKomut.ExecuteNonQuery() == 1)
                        MessageBox.Show(ID + " " + "ID numaralı Kayıt Silindi");
                    AnaMenuForm.con.Close();
                }

            }


            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Silme Hata Penceresi");
            }
        }

        private void btnMusteriKayitSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtId.Text + " " + "ID numaralı kayıt silinecek \nOnaylıyor musunuz?", "Dikkat",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
            {
                MusteriKayitSil();
                //Kayıt Silinince geri listeleme paneline geçecek.
                PersonelKayitSilForm.Control = true;
                AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                frm.btnMusteriListele.PerformClick();

            }
            else
            {
                MessageBox.Show("Kayıt silme işlemi iptal edildi");
                PersonelKayitSilForm.Control = true;
                AnaMenuForm frm = (AnaMenuForm)Application.OpenForms["AnaMenuForm"];
                frm.btnMusteriListele.PerformClick();
            }
        }

        private void MusteriSilForm_Load(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                txtId.Text = ID.ToString();
                maskTxtTc.Text = TcNo;
                txtAd.Text = Ad;
                txtSoyad.Text = Soyad;
                maskTxtTel.Text = Tel;
                txtEPosta.Text = EPosta;
                txtAdres.Text = Adres;

            }
        }
    }
}
