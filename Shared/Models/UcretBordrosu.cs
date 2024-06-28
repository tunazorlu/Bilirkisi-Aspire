using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class UcretBordrosu
    {
        [Key]
        public int UcretBordrosuId { get; set; }

        [Display(Name = "Yıl")]
        public int Yil { get; set; }

        [Display(Name = "Ay")]
        public int Ay { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Ucret")]
        public decimal Ucret { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Fazla Çalışma")]
        public decimal FazlaCalisma { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "UBGT")]
        public decimal UBGT { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Prim")]
        public decimal Prim { get; set; }
        [Column(TypeName = "decimal(8, 2)")]

        public decimal YemekUcreti { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal YolUcreti { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Izin")]
        public decimal Izin { get; set; }

        [Display(Name = "Ücret Bordrosu Var/Yok")]
        public bool? UcretBordrosuVarYok { get; set; } = false;
        [Display(Name = "İmza Var/Yok")]
        public bool ImzaVarYok { get; set; } = false;
        [Display(Name = "Banka Dekontu Var/Yok")]
        public bool BankaDekontuVarYok { get; set; } = false;
        [ForeignKey("MahkemeDosyasi")]
        public int? MahkemeDosyasiId { get; set; }
        public MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
