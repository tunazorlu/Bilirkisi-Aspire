using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class PuantajKaydi
    {
        [Key]
        public int PuantajKaydiId { get; set; }

        [Display(Name = "Yıl")]
        public int Yil { get; set; }

        [Display(Name = "Ay")]
        public int Ay { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Fazla Çalışma")]
        public decimal FazlaCalisma { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "UBGT")]
        public decimal UBGT { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Izin")]
        public decimal Izin { get; set; }

        [Display(Name = "Puantaj Kayıtları Var/Yok")]
        public bool? PuantajKayitlariVarYok { get; set; }
        [ForeignKey("MahkemeDosyasi")]
        public int? MahkemeDosyasiId { get; set; }
        public MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
