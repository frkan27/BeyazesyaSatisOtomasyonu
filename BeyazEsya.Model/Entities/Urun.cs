using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyazEsya.Model.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }

        [StringLength(50)]
        [Required]
        public string UrunAdi { get; set; }


        public decimal Fiyat { get; set; }
        public int KategoriId { get; set; }

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }

        public override string ToString() => $"{UrunAdi}";
    }
}
