
namespace CarRental
{
    partial class AracListeleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGridGuncelle = new System.Windows.Forms.Button();
            this.btnGridSil = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.dataGridArac = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radMarka = new System.Windows.Forms.RadioButton();
            this.radModelYili = new System.Windows.Forms.RadioButton();
            this.radSasiNo = new System.Windows.Forms.RadioButton();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKayitAra = new System.Windows.Forms.Button();
            this.txtPlakaAra = new System.Windows.Forms.TextBox();
            this.txtModelAra = new System.Windows.Forms.TextBox();
            this.chkPlaka = new System.Windows.Forms.CheckBox();
            this.chkModel = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArac)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.btnGridGuncelle);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btnGridSil);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 100);
            this.panel1.TabIndex = 40;
            // 
            // btnGridGuncelle
            // 
            this.btnGridGuncelle.BackColor = System.Drawing.Color.PeachPuff;
            this.btnGridGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGridGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGridGuncelle.Location = new System.Drawing.Point(117, 53);
            this.btnGridGuncelle.Name = "btnGridGuncelle";
            this.btnGridGuncelle.Size = new System.Drawing.Size(111, 40);
            this.btnGridGuncelle.TabIndex = 43;
            this.btnGridGuncelle.Text = "Güncelle";
            this.btnGridGuncelle.UseVisualStyleBackColor = false;
            this.btnGridGuncelle.Click += new System.EventHandler(this.btnGridGuncelle_Click);
            // 
            // btnGridSil
            // 
            this.btnGridSil.BackColor = System.Drawing.Color.PeachPuff;
            this.btnGridSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGridSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGridSil.Location = new System.Drawing.Point(47, 7);
            this.btnGridSil.Name = "btnGridSil";
            this.btnGridSil.Size = new System.Drawing.Size(111, 40);
            this.btnGridSil.TabIndex = 42;
            this.btnGridSil.Text = "Sil";
            this.btnGridSil.UseVisualStyleBackColor = false;
            this.btnGridSil.Click += new System.EventHandler(this.btnGridSil_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(532, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(358, 65);
            this.label23.TabIndex = 22;
            this.label23.Text = "Araç Listeleme";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridArac
            // 
            this.dataGridArac.AllowUserToAddRows = false;
            this.dataGridArac.AllowUserToDeleteRows = false;
            this.dataGridArac.AllowUserToResizeColumns = false;
            this.dataGridArac.AllowUserToResizeRows = false;
            this.dataGridArac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArac.Location = new System.Drawing.Point(0, 100);
            this.dataGridArac.Name = "dataGridArac";
            this.dataGridArac.ReadOnly = true;
            this.dataGridArac.Size = new System.Drawing.Size(1028, 792);
            this.dataGridArac.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1023, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 792);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 792);
            this.panel3.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtHizliAra);
            this.groupBox2.Controls.Add(this.cmbAramaTuru);
            this.groupBox2.Controls.Add(this.lblArananAlan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(3, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 249);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radMarka);
            this.groupBox3.Controls.Add(this.radModelYili);
            this.groupBox3.Controls.Add(this.radSasiNo);
            this.groupBox3.Location = new System.Drawing.Point(4, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 98);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aranan Alan Seçimi";
            // 
            // radMarka
            // 
            this.radMarka.AutoSize = true;
            this.radMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radMarka.Location = new System.Drawing.Point(172, 65);
            this.radMarka.Name = "radMarka";
            this.radMarka.Size = new System.Drawing.Size(76, 24);
            this.radMarka.TabIndex = 4;
            this.radMarka.Text = "Marka";
            this.radMarka.UseVisualStyleBackColor = true;
            this.radMarka.CheckedChanged += new System.EventHandler(this.radMarka_CheckedChanged);
            // 
            // radModelYili
            // 
            this.radModelYili.AutoSize = true;
            this.radModelYili.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radModelYili.Location = new System.Drawing.Point(30, 65);
            this.radModelYili.Name = "radModelYili";
            this.radModelYili.Size = new System.Drawing.Size(104, 24);
            this.radModelYili.TabIndex = 3;
            this.radModelYili.Text = "Model Yılı";
            this.radModelYili.UseVisualStyleBackColor = true;
            this.radModelYili.CheckedChanged += new System.EventHandler(this.radModelYili_CheckedChanged);
            // 
            // radSasiNo
            // 
            this.radSasiNo.AutoSize = true;
            this.radSasiNo.Checked = true;
            this.radSasiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radSasiNo.Location = new System.Drawing.Point(115, 37);
            this.radSasiNo.Name = "radSasiNo";
            this.radSasiNo.Size = new System.Drawing.Size(89, 24);
            this.radSasiNo.TabIndex = 2;
            this.radSasiNo.TabStop = true;
            this.radSasiNo.Text = "Şasi No";
            this.radSasiNo.UseVisualStyleBackColor = true;
            this.radSasiNo.CheckedChanged += new System.EventHandler(this.radSasiNo_CheckedChanged);
            // 
            // txtHizliAra
            // 
            this.txtHizliAra.BackColor = System.Drawing.Color.PeachPuff;
            this.txtHizliAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHizliAra.Location = new System.Drawing.Point(162, 181);
            this.txtHizliAra.Multiline = true;
            this.txtHizliAra.Name = "txtHizliAra";
            this.txtHizliAra.Size = new System.Drawing.Size(143, 35);
            this.txtHizliAra.TabIndex = 4;
            this.txtHizliAra.TextChanged += new System.EventHandler(this.txtHizliAra_TextChanged);
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbAramaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "ile Baslayan",
            "ile Biten",
            "İceren"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(162, 28);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(143, 32);
            this.cmbAramaTuru.TabIndex = 1;
            this.cmbAramaTuru.Text = "ile Başlayan";
            // 
            // lblArananAlan
            // 
            this.lblArananAlan.AutoSize = true;
            this.lblArananAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArananAlan.Location = new System.Drawing.Point(6, 192);
            this.lblArananAlan.Name = "lblArananAlan";
            this.lblArananAlan.Size = new System.Drawing.Size(94, 24);
            this.lblArananAlan.TabIndex = 0;
            this.lblArananAlan.Text = "Şasi No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arama Türü";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKayitAra);
            this.groupBox1.Controls.Add(this.txtPlakaAra);
            this.groupBox1.Controls.Add(this.txtModelAra);
            this.groupBox1.Controls.Add(this.chkPlaka);
            this.groupBox1.Controls.Add(this.chkModel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(5, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 258);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // btnKayitAra
            // 
            this.btnKayitAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayitAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitAra.Location = new System.Drawing.Point(119, 168);
            this.btnKayitAra.Name = "btnKayitAra";
            this.btnKayitAra.Size = new System.Drawing.Size(118, 48);
            this.btnKayitAra.TabIndex = 4;
            this.btnKayitAra.Text = "Ara";
            this.btnKayitAra.UseVisualStyleBackColor = true;
            this.btnKayitAra.Click += new System.EventHandler(this.btnKayitAra_Click);
            // 
            // txtPlakaAra
            // 
            this.txtPlakaAra.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPlakaAra.Enabled = false;
            this.txtPlakaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlakaAra.Location = new System.Drawing.Point(139, 87);
            this.txtPlakaAra.Multiline = true;
            this.txtPlakaAra.Name = "txtPlakaAra";
            this.txtPlakaAra.Size = new System.Drawing.Size(164, 35);
            this.txtPlakaAra.TabIndex = 3;
            // 
            // txtModelAra
            // 
            this.txtModelAra.BackColor = System.Drawing.Color.PeachPuff;
            this.txtModelAra.Enabled = false;
            this.txtModelAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModelAra.Location = new System.Drawing.Point(139, 33);
            this.txtModelAra.Multiline = true;
            this.txtModelAra.Name = "txtModelAra";
            this.txtModelAra.Size = new System.Drawing.Size(164, 35);
            this.txtModelAra.TabIndex = 2;
            // 
            // chkPlaka
            // 
            this.chkPlaka.AutoSize = true;
            this.chkPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkPlaka.Location = new System.Drawing.Point(20, 94);
            this.chkPlaka.Name = "chkPlaka";
            this.chkPlaka.Size = new System.Drawing.Size(79, 28);
            this.chkPlaka.TabIndex = 1;
            this.chkPlaka.Text = "Plaka";
            this.chkPlaka.UseVisualStyleBackColor = true;
            this.chkPlaka.CheckedChanged += new System.EventHandler(this.chkPlaka_CheckedChanged);
            // 
            // chkModel
            // 
            this.chkModel.AutoSize = true;
            this.chkModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkModel.Location = new System.Drawing.Point(20, 40);
            this.chkModel.Name = "chkModel";
            this.chkModel.Size = new System.Drawing.Size(87, 28);
            this.chkModel.TabIndex = 0;
            this.chkModel.Text = "Model";
            this.chkModel.UseVisualStyleBackColor = true;
            this.chkModel.CheckedChanged += new System.EventHandler(this.chkModel_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRental.Properties.Resources.araba;
            this.pictureBox4.Location = new System.Drawing.Point(994, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.araba;
            this.pictureBox3.Location = new System.Drawing.Point(288, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // AracListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 892);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridArac);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AracListeleForm";
            this.Text = "AracListeleForm";
            this.Load += new System.EventHandler(this.AracListeleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArac)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnGridGuncelle;
        private System.Windows.Forms.Button btnGridSil;
        private System.Windows.Forms.DataGridView dataGridArac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radMarka;
        private System.Windows.Forms.RadioButton radModelYili;
        private System.Windows.Forms.RadioButton radSasiNo;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKayitAra;
        private System.Windows.Forms.TextBox txtPlakaAra;
        private System.Windows.Forms.TextBox txtModelAra;
        private System.Windows.Forms.CheckBox chkPlaka;
        private System.Windows.Forms.CheckBox chkModel;
    }
}