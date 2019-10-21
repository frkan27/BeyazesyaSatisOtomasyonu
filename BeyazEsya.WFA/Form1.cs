using BeyazEsya.BLL.HazirData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeyazEsya.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Satis frmSatis;
        private Musteri frmMusteri;
        private UrunEkleForm frmUrunEkle;
        //Bir anaform içinde birden fazla formu kontrol ederken mdiparent i kullanıyoruz.
        //Form1 in isMdiParent ini true yapıyoruz.
        //
        private void sATIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSatis == null || frmSatis.IsDisposed)
            {
                frmSatis = new Satis
                {
                    Text = "Satis formu",
                    MdiParent = this//Yeniaçılcak formu mdi formun childi olarak açmak için bu yapıyı kullanırız.
                };
                frmSatis.Show();

            }
           
        }

        private void mÜŞTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMusteri == null || frmMusteri.IsDisposed)
            {
                frmMusteri = new Musteri
                {
                    Text = "Müşteri formu",
                    MdiParent = this
                };
                frmMusteri.Show();
              
            }
            
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            new HazirData().VeriÜret();
        }

        private void uRUNEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUrunEkle == null || frmUrunEkle.IsDisposed)
            {
                frmUrunEkle = new UrunEkleForm
                {
                    Text = "Ürün Ekle formu",
                    MdiParent = this
                };
                frmUrunEkle.Show();
               
            }
           
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
