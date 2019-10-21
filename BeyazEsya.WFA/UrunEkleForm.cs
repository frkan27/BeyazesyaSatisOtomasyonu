using BeyazEsya.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeyazEsya.Model.Entities;
using BeyazEsya.BLL.Repository;

namespace BeyazEsya.WFA
{
    public partial class UrunEkleForm : Form
    {
        public UrunEkleForm()
        {
            InitializeComponent();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            
            try
            {
                var kategori = new Kategori()
                {
                    KategoriAdi = txtKategori.Text
                };
                new KategoriRepo().Insert(kategori);
                MessageBox.Show("Kategori ekleme basarılı");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            
            try
            {
                var urun = new Urun()
                {
                    UrunAdi = txtMarka.Text,
                    Fiyat=nudFiyat.Value,
                    KategoriId=(cmbKategori.SelectedItem as Kategori).KategoriId
                };
                new UrunRepo().Insert(urun);
                MessageBox.Show("Ürün ekleme basarılı");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UrunEkleForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            cmbKategori.DataSource = new KategoriRepo().GetAll().ToList();
        }
    }
}
