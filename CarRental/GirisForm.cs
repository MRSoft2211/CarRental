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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            if (radYonetici.Checked == true)
            {
                AnaMenuForm.Baglanti();
                string Sorgu = "SELECT * FROM girisDuzeyi where KullaniciAdi=@KullaniciAdi AND KullaniciSifre=@KullaniciSifre";
                SqlCommand cmd = new SqlCommand(Sorgu, AnaMenuForm.con);

                cmd.Parameters.AddWithValue("@KullaniciAdi", txtKlAdi.Text);
                cmd.Parameters.AddWithValue("@KullaniciSifre", txtSifre.Text);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                
                    this.Hide();
                    AnaMenuForm frm = new AnaMenuForm();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı ve şifrenizi kontrol ediniz.");
                }
                AnaMenuForm.con.Close();
            }
            if (radPers.Checked==true)
            {
                AnaMenuForm.Baglanti();
                string Sorgu = "SELECT * FROM Personel where Ad=@Ad AND Sifre=@Sifre";
                SqlCommand cmd = new SqlCommand(Sorgu, AnaMenuForm.con);

                cmd.Parameters.AddWithValue("@Ad", txtKlAdi.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                 
                    AnaMenuForm.PersAdi = Convert.ToString(dr["Ad"]);
                    AnaMenuForm.PersBayiID = Convert.ToInt32(dr["BayiID"]);
                    AnaMenuForm.PersGiris = true;
                    this.Hide();
                    AnaMenuForm frm = new AnaMenuForm();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı ve şifrenizi kontrol ediniz.");
                }
                AnaMenuForm.con.Close();
            }
        
            
        }

        
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void GirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
