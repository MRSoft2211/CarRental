
namespace CarRental
{
    partial class KiraBitirForm
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
            this.dataGridKiraBitir = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKiralamaSonlandır = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKiraBitir)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 100);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRental.Properties.Resources.araba;
            this.pictureBox4.Location = new System.Drawing.Point(925, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(499, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 65);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kira Sonlandır";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.araba;
            this.pictureBox3.Location = new System.Drawing.Point(313, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridKiraBitir
            // 
            this.dataGridKiraBitir.AllowUserToAddRows = false;
            this.dataGridKiraBitir.AllowUserToDeleteRows = false;
            this.dataGridKiraBitir.AllowUserToResizeColumns = false;
            this.dataGridKiraBitir.AllowUserToResizeRows = false;
            this.dataGridKiraBitir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKiraBitir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridKiraBitir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridKiraBitir.Location = new System.Drawing.Point(0, 100);
            this.dataGridKiraBitir.Name = "dataGridKiraBitir";
            this.dataGridKiraBitir.ReadOnly = true;
            this.dataGridKiraBitir.Size = new System.Drawing.Size(1364, 657);
            this.dataGridKiraBitir.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.btnKiralamaSonlandır);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 757);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 135);
            this.panel2.TabIndex = 35;
            // 
            // btnKiralamaSonlandır
            // 
            this.btnKiralamaSonlandır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiralamaSonlandır.Location = new System.Drawing.Point(1157, 41);
            this.btnKiralamaSonlandır.Name = "btnKiralamaSonlandır";
            this.btnKiralamaSonlandır.Size = new System.Drawing.Size(170, 68);
            this.btnKiralamaSonlandır.TabIndex = 34;
            this.btnKiralamaSonlandır.Text = "Sözleşme Sonlandır";
            this.btnKiralamaSonlandır.UseVisualStyleBackColor = true;
            this.btnKiralamaSonlandır.Click += new System.EventHandler(this.btnKiralamaSonlandır_Click);
            // 
            // KiraBitirForm
            // 
            this.AcceptButton = this.btnKiralamaSonlandır;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 892);
            this.Controls.Add(this.dataGridKiraBitir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KiraBitirForm";
            this.Text = "KiraBitirForm";
            this.Load += new System.EventHandler(this.KiraBitirForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKiraBitir)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridKiraBitir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKiralamaSonlandır;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}