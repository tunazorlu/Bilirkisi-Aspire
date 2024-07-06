using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilirkisiAspire.Shared.Models
{
    public class UcretBordrosu
    {
        [Key]
        public int UcretBordrosuId { get; set; }

        [Display(Name = "Yıl")]
        public int Yil { get; set; }

        [Display(Name = "Ay")]
        public int Ay { get; set; }

        [Display(Name = "Ucret")]
        public decimal Ucret { get; set; }

        [Display(Name = "Fazla Çalışma")]
        public decimal FazlaCalisma { get; set; }
        
        [Display(Name = "UBGT")]
        public decimal UBGT { get; set; }
       
        [Display(Name = "Prim")]
        public decimal Prim { get; set; }
       
        public decimal YemekUcreti { get; set; }
        
        public decimal YolUcreti { get; set; }

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
