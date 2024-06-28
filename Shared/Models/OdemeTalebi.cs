using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class OdemeTalebi
    {
        public int OdemeTalebiId { get; set; }
        public string Ad { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Talep Bedeli")]
        public decimal? Bedel { get; set; }
        public int DavaciId { get; set; }
        public virtual Davaci? Davaci{ get; set; }
    }
}
