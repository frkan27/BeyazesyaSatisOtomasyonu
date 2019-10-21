namespace BeyazEsya.WFA
{
    partial class Satis
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
            this.pnlMusteriBilgi = new System.Windows.Forms.Panel();
            this.nudTaksit = new System.Windows.Forms.NumericUpDown();
            this.nudPesinat = new System.Windows.Forms.NumericUpDown();
            this.lblTaksit = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblPesinat = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.btnSat = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.txtMüsteri = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.pnlUrun = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMusteriBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaksit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesinat)).BeginInit();
            this.pnlUrun.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMusteriBilgi
            // 
            this.pnlMusteriBilgi.Controls.Add(this.nudTaksit);
            this.pnlMusteriBilgi.Controls.Add(this.nudPesinat);
            this.pnlMusteriBilgi.Controls.Add(this.lblTaksit);
            this.pnlMusteriBilgi.Controls.Add(this.lblAdres);
            this.pnlMusteriBilgi.Controls.Add(this.lblPesinat);
            this.pnlMusteriBilgi.Controls.Add(this.lblMusteri);
            this.pnlMusteriBilgi.Controls.Add(this.btnSat);
            this.pnlMusteriBilgi.Controls.Add(this.txtAdres);
            this.pnlMusteriBilgi.Controls.Add(this.txtMüsteri);
            this.pnlMusteriBilgi.Location = new System.Drawing.Point(42, 158);
            this.pnlMusteriBilgi.Name = "pnlMusteriBilgi";
            this.pnlMusteriBilgi.Size = new System.Drawing.Size(485, 221);
            this.pnlMusteriBilgi.TabIndex = 9;
           
            // 
            // nudTaksit
            // 
            this.nudTaksit.Location = new System.Drawing.Point(344, 94);
            this.nudTaksit.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudTaksit.Name = "nudTaksit";
            this.nudTaksit.Size = new System.Drawing.Size(101, 20);
            this.nudTaksit.TabIndex = 10;
            // 
            // nudPesinat
            // 
            this.nudPesinat.Location = new System.Drawing.Point(344, 30);
            this.nudPesinat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPesinat.Name = "nudPesinat";
            this.nudPesinat.Size = new System.Drawing.Size(101, 20);
            this.nudPesinat.TabIndex = 9;
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Location = new System.Drawing.Point(269, 94);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(36, 13);
            this.lblTaksit.TabIndex = 8;
            this.lblTaksit.Text = "Taksit";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(29, 97);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 7;
            this.lblAdres.Text = "Adres";
            // 
            // lblPesinat
            // 
            this.lblPesinat.AutoSize = true;
            this.lblPesinat.Location = new System.Drawing.Point(269, 30);
            this.lblPesinat.Name = "lblPesinat";
            this.lblPesinat.Size = new System.Drawing.Size(42, 13);
            this.lblPesinat.TabIndex = 6;
            this.lblPesinat.Text = "Peşinat";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(27, 29);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(94, 13);
            this.lblMusteri.TabIndex = 5;
            this.lblMusteri.Text = "Müşteri Adı Soyadı";
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(344, 167);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(75, 23);
            this.btnSat.TabIndex = 4;
            this.btnSat.Text = "Sat";
            this.btnSat.UseVisualStyleBackColor = true;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(126, 94);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 64);
            this.txtAdres.TabIndex = 2;
            this.txtAdres.Text = "";
            // 
            // txtMüsteri
            // 
            this.txtMüsteri.Location = new System.Drawing.Point(126, 29);
            this.txtMüsteri.Name = "txtMüsteri";
            this.txtMüsteri.Size = new System.Drawing.Size(100, 20);
            this.txtMüsteri.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(529, 47);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Müşteri Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(336, 47);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyat";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(155, 39);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(149, 21);
            this.cmbMarka.TabIndex = 6;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(18, 39);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunler.TabIndex = 5;
            this.cmbUrunler.SelectedIndexChanged += new System.EventHandler(this.cmbUrunler_SelectedIndexChanged);
            // 
            // pnlUrun
            // 
            this.pnlUrun.Controls.Add(this.label2);
            this.pnlUrun.Controls.Add(this.label1);
            this.pnlUrun.Controls.Add(this.cmbUrunler);
            this.pnlUrun.Controls.Add(this.cmbMarka);
            this.pnlUrun.Controls.Add(this.btnEkle);
            this.pnlUrun.Controls.Add(this.lblFiyat);
            this.pnlUrun.Location = new System.Drawing.Point(24, 12);
            this.pnlUrun.Name = "pnlUrun";
            this.pnlUrun.Size = new System.Drawing.Size(634, 126);
            this.pnlUrun.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kategori";
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlUrun);
            this.Controls.Add(this.pnlMusteriBilgi);
            this.Name = "Satis";
            this.Text = "Satis";
            this.Load += new System.EventHandler(this.Satis_Load);
            this.pnlMusteriBilgi.ResumeLayout(false);
            this.pnlMusteriBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaksit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesinat)).EndInit();
            this.pnlUrun.ResumeLayout(false);
            this.pnlUrun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMusteriBilgi;
        private System.Windows.Forms.Label lblTaksit;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblPesinat;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.TextBox txtMüsteri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.NumericUpDown nudPesinat;
        private System.Windows.Forms.NumericUpDown nudTaksit;
        private System.Windows.Forms.Panel pnlUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}