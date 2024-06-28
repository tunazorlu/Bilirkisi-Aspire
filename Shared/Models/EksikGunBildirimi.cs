using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class EksikGunBildirimi
    {
        public int? EksikGunBildirimiId { get; set; }

        [Display(Name = "Eksik Gün Bildirilen Ay")]
        public int? EksikGunBildirilenAy { get; set; }   
        
        [Display(Name = "Eksik Gün Bildirilen Yıl")]
        public int? EksikGunBildirilenYil { get; set; }

        [Display(Name = "Eksik Gün Nedeni")]
        public string? EksikGunNedeni { get; set; }   
        
        [Display(Name = "İşten Çıkış Kodu")]
        public string? IstenCikisKodu { get; set; }
        public int SgkIncelemesiId { get; set; }
        public virtual SgkIncelemesi SgkIncelemesi { get; set; }
    }
}
