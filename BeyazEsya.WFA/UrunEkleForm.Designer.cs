namespace BeyazEsya.WFA
{
    partial class UrunEkleForm
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
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblUrun = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKategor = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(97, 46);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(100, 20);
            this.txtKategori.TabIndex = 0;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(23, 49);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(64, 13);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori Adı";
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(111, 110);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(75, 23);
            this.btnKategori.TabIndex = 2;
            this.btnKategori.Text = "Ekle";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(119, 162);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtKategori);
            this.panel1.Controls.Add(this.lblKategori);
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Location = new System.Drawing.Point(32, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 188);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbKategori);
            this.panel2.Controls.Add(this.nudFiyat);
            this.panel2.Controls.Add(this.txtMarka);
            this.panel2.Controls.Add(this.lblKategor);
            this.panel2.Controls.Add(this.lblFiyat);
            this.panel2.Controls.Add(this.LblUrun);
            this.panel2.Controls.Add(this.btnUrunEkle);
            this.panel2.Location = new System.Drawing.Point(350, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 188);
            this.panel2.TabIndex = 5;
            // 
            // LblUrun
            // 
            this.LblUrun.AutoSize = true;
            this.LblUrun.Location = new System.Drawing.Point(18, 30);
            this.LblUrun.Name = "LblUrun";
            this.LblUrun.Size = new System.Drawing.Size(58, 13);
            this.LblUrun.TabIndex = 4;
            this.LblUrun.Text = "Marka Adı:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(18, 81);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(37, 13);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "Fiyatı :";
            // 
            // lblKategor
            // 
            this.lblKategor.AutoSize = true;
            this.lblKategor.Location = new System.Drawing.Point(18, 128);
            this.lblKategor.Name = "lblKategor";
            this.lblKategor.Size = new System.Drawing.Size(68, 13);
            this.lblKategor.TabIndex = 6;
            this.lblKategor.Text = "Kategori Seç";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(110, 23);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(120, 20);
            this.txtMarka.TabIndex = 7;
            // 
            // nudFiyat
            // 
            this.nudFiyat.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFiyat.Location = new System.Drawing.Point(110, 74);
            this.nudFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 8;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(110, 120);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(120, 21);
            this.cmbKategori.TabIndex = 9;
            // 
            // UrunEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UrunEkleForm";
            this.Text = "UrunEkleForm";
            this.Load += new System.EventHandler(this.UrunEkleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblKategor;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label LblUrun;
        private System.Windows.Forms.ComboBox cmbKategori;
    }
}