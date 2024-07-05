using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilirkisiAspire.Shared.Models
{
    public class PuantajKaydi
    {
        [Key]
        public int PuantajKaydiId { get; set; }

        [Display(Name = "Yıl")]
        public int Yil { get; set; }

        [Display(Name = "Ay")]
        public int Ay { get; set; }

        [Display(Name = "Fazla Çalışma")]
        public decimal FazlaCalisma { get; set; }

        [Display(Name = "UBGT")]
        public decimal UBGT { get; set; }

        [Display(Name = "Izin")]
        public decimal Izin { get; set; }

        [Display(Name = "Puantaj Kayıtları Var/Yok")]
        public bool? PuantajKayitlariVarYok { get; set; }
        [ForeignKey("MahkemeDosyasi")]
        public int? MahkemeDosyasiId { get; set; }
        public MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
