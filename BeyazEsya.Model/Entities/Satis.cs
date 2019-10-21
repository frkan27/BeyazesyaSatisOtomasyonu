using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyazEsya.Model.Entities
{
    [Table("Satislar")]
   public  class Satis
    {
        [Key]
        [Column(Order = 1)]
        public int MusteriId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UrunId { get; set; }


        [ForeignKey("MusteriId")]
        public virtual Musteri Musteri { get; set; }

        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }

        public decimal Pesinat { get; set; }
        public int Taksit { get; set; }
    }
}
