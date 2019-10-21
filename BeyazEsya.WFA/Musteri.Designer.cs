namespace BeyazEsya.WFA
{
    partial class Musteri
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
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.dgvMusteri = new System.Windows.Forms.DataGridView();
            this.pnlTaksitKontrol = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEvet = new System.Windows.Forms.CheckBox();
            this.cbHayir = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).BeginInit();
            this.pnlTaksitKontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Items.AddRange(new object[] {
            "müşteri seç"});
            this.cmbMusteri.Location = new System.Drawing.Point(137, 51);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteri.TabIndex = 1;
            this.cmbMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbMusteri_SelectedIndexChanged);
            // 
            // dgvMusteri
            // 
            this.dgvMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteri.Location = new System.Drawing.Point(69, 102);
            this.dgvMusteri.Name = "dgvMusteri";
            this.dgvMusteri.Size = new System.Drawing.Size(614, 192);
            this.dgvMusteri.TabIndex = 2;
            this.dgvMusteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteri_CellClick);
            // 
            // pnlTaksitKontrol
            // 
            this.pnlTaksitKontrol.Controls.Add(this.cbHayir);
            this.pnlTaksitKontrol.Controls.Add(this.cbEvet);
            this.pnlTaksitKontrol.Controls.Add(this.label1);
            this.pnlTaksitKontrol.Location = new System.Drawing.Point(69, 316);
            this.pnlTaksitKontrol.Name = "pnlTaksitKontrol";
            this.pnlTaksitKontrol.Size = new System.Drawing.Size(614, 100);
            this.pnlTaksitKontrol.TabIndex = 3;
            this.pnlTaksitKontrol.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taksit ödendi mi ?";
            // 
            // cbEvet
            // 
            this.cbEvet.AutoSize = true;
            this.cbEvet.Location = new System.Drawing.Point(169, 26);
            this.cbEvet.Name = "cbEvet";
            this.cbEvet.Size = new System.Drawing.Size(54, 17);
            this.cbEvet.TabIndex = 1;
            this.cbEvet.Text = "EVET";
            this.cbEvet.UseVisualStyleBackColor = true;
            this.cbEvet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbEvet_MouseClick);
            // 
            // cbHayir
            // 
            this.cbHayir.AutoSize = true;
            this.cbHayir.Location = new System.Drawing.Point(287, 26);
            this.cbHayir.Name = "cbHayir";
            this.cbHayir.Size = new System.Drawing.Size(59, 17);
            this.cbHayir.TabIndex = 1;
            this.cbHayir.Text = "HAYIR";
            this.cbHayir.UseVisualStyleBackColor = true;
            this.cbHayir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbHayir_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri Adı :";
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTaksitKontrol);
            this.Controls.Add(this.dgvMusteri);
            this.Controls.Add(this.cmbMusteri);
            this.Name = "Musteri";
            this.Text = "Musteri";
            this.Activated += new System.EventHandler(this.Musteri_Activated_1);
            this.Load += new System.EventHandler(this.Musteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).EndInit();
            this.pnlTaksitKontrol.ResumeLayout(false);
            this.pnlTaksitKontrol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.DataGridView dgvMusteri;
        private System.Windows.Forms.Panel pnlTaksitKontrol;
        private System.Windows.Forms.CheckBox cbHayir;
        private System.Windows.Forms.CheckBox cbEvet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}