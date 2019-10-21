using BeyazEsya.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyazEsya.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=BeyazCon")
        {

        }

        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }
    }
}
