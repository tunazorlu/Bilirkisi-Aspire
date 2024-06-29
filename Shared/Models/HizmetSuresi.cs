using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models
{
    public class HizmetSuresi
    {
        public int? HizmetSuresiId { get; set; }
        public DateTime? IseGirisTarihi { get; set; }
        public DateTime? IstenCikisTarihi { get; set; }
        public bool SgkKayitlari { get; set; }
        public bool TanikBeyanlari { get; set; }
        public bool UcretBordrolari { get; set; }
        public bool TalepleBaglilikIlkesi { get; set; }
        public int? MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
