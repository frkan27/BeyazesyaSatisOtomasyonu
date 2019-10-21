using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyazEsya.Model.Entities
{
    [Table("Musteriler")]
    public class Musteri
    {
        [Key]
        public int MusteriId { get; set; }

        [StringLength(50)]
        [Required]
        public string MusteriAdi { get; set; }
        public string Adres { get; set; }
      
     

        public override string ToString() => $"{MusteriAdi} ";
    }
}
