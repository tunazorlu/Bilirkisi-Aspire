using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models
{
    public class HizmetSuresi
    {
        [Key]
        public int? HizmetSuresiId { get; set; }
        [Display(Name = "Hesaplamalara Esas İşe Giriş Tarihi")]
        public DateOnly? IseGirisTarihi { get; set; }
        [Display(Name = "Hesaplamalara Esas İşten ÇıkışTarihi")]
        public DateOnly? IstenCikisTarihi { get; set; }
        [Display(Name = "SGK Kayıtları")]
        public bool SgkKayitlari { get; set; }
        [Display(Name = "Tanık Beyanları")]
        public bool TanikBeyanlari { get; set; }
        [Display(Name = "Ücret Bordroları")]
        public bool UcretBordrolari { get; set; }
        [Display(Name = "Taleple Bağlılık İlkesi")]
        public bool TalepleBaglilikIlkesi { get; set; }
        [ForeignKey("MahkemeDosyasi")]
        public int? MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
