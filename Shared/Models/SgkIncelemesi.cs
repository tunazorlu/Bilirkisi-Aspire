using System.ComponentModel.DataAnnotations;

namespace BilirkisiAspire.Shared.Models
{
    public class SgkIncelemesi
    {
        public int? SgkIncelemesiId { get; set; }
        [Display(Name = "Sigorta İşe Giriş Tarihi")]
        public DateOnly? SigortaIseGirisTarihi { get; set; }
        [Display(Name = "Sigorta İşten Ayrılış Tarihi")]
        public DateOnly? SigortaIstenAyrilisTarihi { get; set; }
        [Display(Name = "Sigorta Sicil No")]
        public string? SigortaSicilNo { get; set; }

        [Display(Name = "İşveren Ünvanı")]
        public string? IsverenUnvani { get; set; }

        [Display(Name = "Çalışılan Gün")]
        public int? CalisilanGun { get; set; }
        public int MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
        public virtual List<EksikGunBildirimi>? EksikGunBildirimleri { get; set; } = new List<EksikGunBildirimi>();
    }
}
