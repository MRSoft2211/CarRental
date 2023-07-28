
namespace CarRental
{
    partial class AracKiralaForm
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridMusteri = new System.Windows.Forms.DataGridView();
            this.btnAraçTeslimEt = new System.Windows.Forms.Button();
            this.dtBaslangıc = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridArac = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArac)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 100);
            this.panel1.TabIndex = 32;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRental.Properties.Resources.araba;
            this.pictureBox4.Location = new System.Drawing.Point(948, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(522, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 65);
            this.label1.TabIndex = 19;
            this.label1.Text = "Araç Kiralama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.araba;
            this.pictureBox3.Location = new System.Drawing.Point(336, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridMusteri
            // 
            this.dataGridMusteri.AllowUserToAddRows = false;
            this.dataGridMusteri.AllowUserToDeleteRows = false;
            this.dataGridMusteri.AllowUserToResizeColumns = false;
            this.dataGridMusteri.AllowUserToResizeRows = false;
            this.dataGridMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridMusteri.Location = new System.Drawing.Point(0, 100);
            this.dataGridMusteri.Name = "dataGridMusteri";
            this.dataGridMusteri.ReadOnly = true;
            this.dataGridMusteri.Size = new System.Drawing.Size(1364, 281);
            this.dataGridMusteri.TabIndex = 96;
            // 
            // btnAraçTeslimEt
            // 
            this.btnAraçTeslimEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAraçTeslimEt.Location = new System.Drawing.Point(990, 722);
            this.btnAraçTeslimEt.Name = "btnAraçTeslimEt";
            this.btnAraçTeslimEt.Size = new System.Drawing.Size(147, 93);
            this.btnAraçTeslimEt.TabIndex = 98;
            this.btnAraçTeslimEt.Text = "Sözleşme Oluştur";
            this.btnAraçTeslimEt.UseVisualStyleBackColor = true;
            this.btnAraçTeslimEt.Click += new System.EventHandler(this.btnAraçTeslimEt_Click);
            // 
            // dtBaslangıc
            // 
            this.dtBaslangıc.CalendarMonthBackground = System.Drawing.Color.AntiqueWhite;
            this.dtBaslangıc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtBaslangıc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangıc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBaslangıc.Location = new System.Drawing.Point(83, 748);
            this.dtBaslangıc.Name = "dtBaslangıc";
            this.dtBaslangıc.Size = new System.Drawing.Size(267, 31);
            this.dtBaslangıc.TabIndex = 99;
            // 
            // dtBitis
            // 
            this.dtBitis.CalendarMonthBackground = System.Drawing.Color.AntiqueWhite;
            this.dtBitis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBitis.Location = new System.Drawing.Point(397, 748);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(267, 31);
            this.dtBitis.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(124, 710);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 101;
            this.label2.Text = "Araç Teslim Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(443, 710);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Araç Teslim Alım";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 19);
            this.panel2.TabIndex = 102;
            // 
            // dataGridArac
            // 
            this.dataGridArac.AllowUserToAddRows = false;
            this.dataGridArac.AllowUserToDeleteRows = false;
            this.dataGridArac.AllowUserToResizeColumns = false;
            this.dataGridArac.AllowUserToResizeRows = false;
            this.dataGridArac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridArac.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridArac.Location = new System.Drawing.Point(0, 400);
            this.dataGridArac.Name = "dataGridArac";
            this.dataGridArac.ReadOnly = true;
            this.dataGridArac.Size = new System.Drawing.Size(1364, 281);
            this.dataGridArac.TabIndex = 103;
            // 
            // AracKiralaForm
            // 
            this.AcceptButton = this.btnAraçTeslimEt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1364, 892);
            this.Controls.Add(this.dataGridArac);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangıc);
            this.Controls.Add(this.btnAraçTeslimEt);
            this.Controls.Add(this.dataGridMusteri);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AracKiralaForm";
            this.Text = "AracKiralaForm";
            this.Load += new System.EventHandler(this.AracKiralaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridMusteri;
        private System.Windows.Forms.Button btnAraçTeslimEt;
        private System.Windows.Forms.DateTimePicker dtBaslangıc;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridArac;
    }
}