using BeyazEsya.BLL.Repository;
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

namespace BeyazEsya.WFA
{
    public partial class Musteri : Form
    {
        DataGridViewCell cell;
        public Musteri()
        {
            InitializeComponent();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;//Sayfayı kapla
            cmbMusteri.DataSource = new MusteriRepo().GetAll().ToList();
        }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            var musteri = cmbMusteri.SelectedItem as BeyazEsya.Model.Entities.Musteri;
     
            if (musteri != null)
            {
                var sorgu2 = from u in db.Urunler
                             join s in db.Satislar on u.UrunId equals s.UrunId
                             join m in db.Musteriler on s.MusteriId equals m.MusteriId
                             where m.MusteriId == musteri.MusteriId
                             select new
                             {
                                 AdıSoyadı = m.MusteriAdi,
                                 ÜrünAdı = u.UrunAdi,
                                 Fiyatı = u.Fiyat,
                                 Peşinat=s.Pesinat,
                                 TaksitSayısı=s.Taksit,
                                 AylıkMiktar= (int)(u.Fiyat-s.Pesinat)/s.Taksit
                             };

                dgvMusteri.DataSource = sorgu2.ToList(); 
            }

           
        }

        private void Musteri_Activated_1(object sender, EventArgs e)
        {
            cmbMusteri.SelectedIndex = -1;//Comboboxta ilk index boş gelsin diye yapıyoruz.
        }

        private void dgvMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMusteri.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                pnlTaksitKontrol.Visible = true;//DataGridView daki hücreye tıkladığımızda panel açılıyor.
                cell = dgvMusteri.Rows[e.RowIndex].Cells[e.ColumnIndex];
                         
            }
        }

        private void cbEvet_MouseClick(object sender, MouseEventArgs e)
        {
            cbHayir.Enabled = false;
            DialogResult tikla= MessageBox.Show($"{cell.Value.ToString()} tl lik taksit ödenmiştir.");
            cell.Style.BackColor = Color.Green;
            if (tikla==DialogResult.OK)
            {
                pnlTaksitKontrol.Visible = false;
                cbEvet.Checked = false;
            }
        }

        private void cbHayir_MouseClick(object sender, MouseEventArgs e)
        {
            cell.Style.BackColor = Color.Red;
        }

      
    }
}
