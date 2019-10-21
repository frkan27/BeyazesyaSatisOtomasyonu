using BeyazEsya.BLL.Repository;
using BeyazEsya.DAL;
using BeyazEsya.Model.Entities;
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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                var seciliUrun = cmbMarka.SelectedItem as Urun;
                var urunId = db.Urunler.FirstOrDefault(x => x.UrunId == seciliUrun.UrunId).UrunId;//urunıd ile seçili ürünün ıd si ilk eşit olunca seçer.
                var model = new Model.Entities.Musteri()
                {
                    MusteriAdi = txtMüsteri.Text,
                    Adres = txtAdres.Text,
                };
                new MusteriRepo().Insert(model);
                new SatisDetayRepo().Insert(new Model.Entities.Satis
                {
                    MusteriId = model.MusteriId,
                    UrunId = urunId,
                    Pesinat = nudPesinat.Value,
                    Taksit = (int)nudTaksit.Value
                });
                MessageBox.Show("Musteri ekleme basarılı");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            pnlMusteriBilgi.Visible = false;
            pnlUrun.Visible = true;
            
        }

        private void Satis_Load(object sender, EventArgs e)
        {
            
            this.Dock = DockStyle.Fill;//Sayfayı doldur..
            cmbUrunler.DataSource = new KategoriRepo().GetAll().ToList();
            pnlMusteriBilgi.Visible = false;
        }

        private void cmbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try  //Seçtiğimiz kategoriye ait markaları cmbMarka da listeliyor.
            {
                MyContext db = new MyContext();
                var seciliKategori = cmbUrunler.SelectedItem as Kategori;
                var marka = db.Urunler.Where(x => x.KategoriId == seciliKategori.KategoriId).ToList();
                cmbMarka.DataSource = marka;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçili ürünün bilgilerini labela yazdırıyor.
            var seciliUrun = cmbMarka.SelectedItem as Urun;        
            lblFiyat.Text = $"Ürün Adı:{seciliUrun.UrunAdi}\nBirim Fiyatı:{seciliUrun.Fiyat}" + $"\nÜrün Kategorisi: {seciliUrun.Kategori}\n";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            pnlMusteriBilgi.Visible = true;        
            pnlUrun.Visible = false;
            FormuTemizle(this.pnlMusteriBilgi);
        }

       //???? paremetre olayını sor...
        private void FormuTemizle(Control parent)
        {
            foreach (Control control in parent.Controls)//formun içinde control tipinde dönüyoruz.
            {
                if (control is TextBox)  
                    control.Text = string.Empty;

                if (control is RichTextBox)
                    control.Text = string.Empty;

                if (control is NumericUpDown nud)
                    nud.Value = 0;


            }

        }
    }
}
