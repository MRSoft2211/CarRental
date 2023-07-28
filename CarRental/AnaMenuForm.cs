 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;



namespace CarRental
{
    public partial class AnaMenuForm : Form
    {
        private bool isCollapsed;

        public static bool PersGiris;

        public static string PersAdi;
        public static int PersBayiID;

        public AnaMenuForm()
        {
            InitializeComponent();
        }
        
        private void AnaMenuForm_Load(object sender, EventArgs e)
        {
  
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Text = "";
            }

            if (PersGiris==true)
            {
                pnlPersonel.Visible = false;
            }

        }

        public static SqlConnection con = new SqlConnection("server=             \\SQLEXPRESS; Initial Catalog=CarRental;Integrated Security=SSPI");

        
        
        public static void Baglanti()
        {
            try
            {
                con.Open();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Baglanti Açma Hata Penceresi");
            }
        }

        

        
        private void timerAnamenu_tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                panelAnaMenu.Height += 10;
                if (panelAnaMenu.Size == panelAnaMenu.MaximumSize)
                {
                    timerAnaMenu.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                panelAnaMenu.Height -= 10;
                if (panelAnaMenu.Size == panelAnaMenu.MinimumSize)
                {
                    timerAnaMenu.Stop();
                    isCollapsed = true;
                }
            }
        }





        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            //timerAnaMenu.Start();
            //pnl.Size = pnlPersonel.MinimumSize;
            tabControl1.SelectedTab = tpAnaMenu;
        }

        


        private void btnPersonel_Click(object sender, EventArgs e)
        {
            timerPersonel.Start();
            
        }

        private void timerPersonel_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                pnlPersonel.Height += 10;
                if (pnlPersonel.Size == pnlPersonel.MaximumSize)
                {
                    timerPersonel.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                pnlPersonel.Height -= 10;
                if (pnlPersonel.Size == pnlPersonel.MinimumSize)
                {
                    timerPersonel.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnAracYonetim_Click(object sender, EventArgs e)
        {
            timerAracYonetimi.Start();
        }
        private void timerAracYonetimi_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                pnlAracYonetim.Height += 10;
                if (pnlAracYonetim.Size == pnlAracYonetim.MaximumSize)
                {
                    timerAracYonetimi.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                pnlAracYonetim.Height -= 10;
                if (pnlAracYonetim.Size == pnlAracYonetim.MinimumSize)
                {
                    timerAracYonetimi.Stop();
                    isCollapsed = true;
                }
            }
        }


        private void btnpersonelKayıtEkle_Click(object sender, EventArgs e)
        {
            PersonelKayitEkleForm frmPersKayitEkle = new PersonelKayitEkleForm();
            tabControl1.SelectedTab = tpPersKayitEkle;
            frmPersKayitEkle.TopLevel = false;
            tpPersKayitEkle.Controls.Add(frmPersKayitEkle);
            frmPersKayitEkle.Dock = DockStyle.Fill;
            frmPersKayitEkle.Show();


        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Uygulamayı Kapatmak İstiyor Musunuz ?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }
 
        private void btnKayitListele_Click(object sender, EventArgs e)
        {
            PersonelKayitListeleForm frmPersKayitListele = new PersonelKayitListeleForm();
            tabControl1.SelectedTab = tpPersKayitListele;
            frmPersKayitListele.TopLevel = false;
            tpPersKayitListele.Controls.Add(frmPersKayitListele);
            frmPersKayitListele.Show();
            frmPersKayitListele.Dock = DockStyle.Fill;
            PersonelKayitListeleForm.KayitListele();
          
        }

        private void btnPersonelKayitGüncelle_Click(object sender, EventArgs e)
        {
            PersonelKayitGuncelleForm frmGuncelle = new PersonelKayitGuncelleForm();
            tabControl1.SelectedTab = tpPersKayitGuncelle;
            frmGuncelle.TopLevel = false;
            tpPersKayitGuncelle.Controls.Add(frmGuncelle);
            frmGuncelle.Show();
            frmGuncelle.Dock = DockStyle.Fill;
            
        }

        public void btnPersKayitSil_Click(object sender, EventArgs e)
        {

            PersonelKayitSilForm frmPerskayitSil = new PersonelKayitSilForm();
          
            tabControl1.SelectedTab = tpPersKayitSil;
            frmPerskayitSil.TopLevel = false;
            tpPersKayitSil.Controls.Add(frmPerskayitSil);
            frmPerskayitSil.Show();
            frmPerskayitSil.Dock = DockStyle.Fill;            

        }

        private void btnAracTanimlama_Click(object sender, EventArgs e)
        {
            AracTanimForm frmAracYonetim = new AracTanimForm();
            tabControl1.SelectedTab = tpAracTanımlama;
            frmAracYonetim.TopLevel = false;
            tpAracTanımlama.Controls.Add(frmAracYonetim);
            frmAracYonetim.Show();
            frmAracYonetim.Dock = DockStyle.Fill;
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            AracListeleForm frmAracListele = new AracListeleForm();
            tabControl1.SelectedTab = tpAracListele;
            frmAracListele.TopLevel = false;
            tpAracListele.Controls.Add(frmAracListele);
            frmAracListele.Show();
            frmAracListele.Dock = DockStyle.Fill;
            AracListeleForm.AracListele();
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            AracSilForm frmAracSil = new AracSilForm();
            tabControl1.SelectedTab = tpAracSil;
            frmAracSil.TopLevel = false;
            tpAracSil.Controls.Add(frmAracSil);
            frmAracSil.Show();
            frmAracSil.Dock = DockStyle.Fill;
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            AracGuncelleForm frmAracGuncelle = new AracGuncelleForm();
            tabControl1.SelectedTab = tpAracGuncelle;
            frmAracGuncelle.TopLevel = false;
            tpAracGuncelle.Controls.Add(frmAracGuncelle);
            frmAracGuncelle.Show();
            frmAracGuncelle.Dock = DockStyle.Fill;
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            timerMusteri.Start();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelleForm frmGuncelle = new MusteriGuncelleForm();
            tabControl1.SelectedTab = tpMusteriGuncelle;
            frmGuncelle.TopLevel = false;
            tpMusteriGuncelle.Controls.Add(frmGuncelle);
            frmGuncelle.Show();
            frmGuncelle.Dock = DockStyle.Fill;
            MusteriListeleForm.KayitListele();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListeleForm frmListele = new MusteriListeleForm();
            tabControl1.SelectedTab = tpMusteriListele;
            frmListele.TopLevel = false;
            tpMusteriListele.Controls.Add(frmListele);
            frmListele.Show();
            frmListele.Dock = DockStyle.Fill;
            MusteriListeleForm.KayitListele();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkleForm frmEkle = new MusteriEkleForm();
            tabControl1.SelectedTab = tpMusteriEkle;
            frmEkle.TopLevel = false;
            tpMusteriEkle.Controls.Add(frmEkle);
            frmEkle.Show();
            frmEkle.Dock = DockStyle.Fill;
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            MusteriSilForm frmSil = new MusteriSilForm();
            tabControl1.SelectedTab = tpMusteriSil;
            frmSil.TopLevel = false;
            tpMusteriSil.Controls.Add(frmSil);
            frmSil.Show();
            frmSil.Dock = DockStyle.Fill;
        }

        private void timerMusteri_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                pnlMusteri.Height += 10;
                if (pnlMusteri.Size == pnlMusteri.MaximumSize)
                {
                    timerMusteri.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                pnlMusteri.Height -= 10;
                if (pnlMusteri.Size == pnlMusteri.MinimumSize)
                {
                    timerMusteri.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnAracKiralama_Click(object sender, EventArgs e)
        {
           timerAracKirala.Start();
        }

        

        private void btnAracTeslimEt_Click(object sender, EventArgs e)
        {
            AracKiralaForm frmKirala = new AracKiralaForm();
            tabControl1.SelectedTab = tpAracTeslimEt;
            frmKirala.TopLevel = false;
            tpAracTeslimEt.Controls.Add(frmKirala);
            frmKirala.Show();
            frmKirala.Dock = DockStyle.Fill;
        }

        private void btnAracTeslimAl_Click(object sender, EventArgs e)
        {
            KiraBitirForm frm = new KiraBitirForm();
            tabControl1.SelectedTab = tpAracTeslimAl;
            frm.TopLevel = false;
            tpAracTeslimAl.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        private void timerAracKirala_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                pnlAracKirala.Height += 10;
                if (pnlAracKirala.Size == pnlAracKirala.MaximumSize)
                {
                    timerAracKirala.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                pnlAracKirala.Height -= 10;
                if (pnlAracKirala.Size == pnlAracKirala.MinimumSize)
                {
                    timerAracKirala.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnSozlesmeler_Click(object sender, EventArgs e)
        {
            timerSozlesmeler.Start();
        }

        private void btnAracTeslimEtSozlesme_Click(object sender, EventArgs e)
        {
            AracKiraSozlesmeForm frmSozlesme = new AracKiraSozlesmeForm();
            tabControl1.SelectedTab = tpAracTeslimEtSozlesme;
            frmSozlesme.TopLevel = false;
            tpAracTeslimEtSozlesme.Controls.Add(frmSozlesme);
            frmSozlesme.Show();
            frmSozlesme.Dock = DockStyle.Fill;
        }

        private void btnAracTeslimAlSozlesme_Click(object sender, EventArgs e)
        {
            AracTeslimAlForm frmSozlesme = new AracTeslimAlForm();
            tabControl1.SelectedTab = tpAracTeslimAlSozlesme;
            frmSozlesme.TopLevel = false;
            tpAracTeslimAlSozlesme.Controls.Add(frmSozlesme);
            frmSozlesme.Show();
            frmSozlesme.Dock = DockStyle.Fill;
        }

        private void btnBitmisSozlesme_Click(object sender, EventArgs e)
        {
            TamamlananSozlesmeForm frm = new TamamlananSozlesmeForm();
            tabControl1.SelectedTab = tpBitmisSozlesme;
            frm.TopLevel = false;
            tpBitmisSozlesme.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        private void timerSozlesmeler_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {

                pnlSozlesme.Height += 10;
                if (pnlSozlesme.Size == pnlSozlesme.MaximumSize)
                {
                    timerSozlesmeler.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                pnlSozlesme.Height -= 10;
                if (pnlSozlesme.Size == pnlSozlesme.MinimumSize)
                {
                    timerSozlesmeler.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnKiradaSozlesme_Click(object sender, EventArgs e)
        {

            KiradaSozlesmelerForm frm = new KiradaSozlesmelerForm();
            tabControl1.SelectedTab = tpKiradaSozlesmeler;
            frm.TopLevel = false;
            tpKiradaSozlesmeler.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            OdemeForm frm = new OdemeForm();
            tabControl1.SelectedTab = tpOdeme;
            frm.TopLevel = false;
            tpOdeme.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

       

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            timerRapor.Start();

        }

       

       

       

        

        

    }

    public static class FormIslem
    {
        public static void DatagridviewTasarimDegistir(this DataGridView datagridview)
        {
           
                //İlk sütunun gizlenmesini sağlar
                datagridview.RowHeadersVisible = false;
                //Herhangibir sütunun genişliğini o sütunda yer alan en uzun değere göre ayarlar
               // datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //Datagridview border sıfırlama
                datagridview.BorderStyle = BorderStyle.None;

                datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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


