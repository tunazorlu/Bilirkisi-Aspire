using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class DavaciVekili
    {
        public int DavaciVekiliId { get; set; }
        [Display(Name = "Davacı Vekili Adı")]
        public string? Ad { get; set; }
        [Display(Name = "Davacı Vekili Soyadı")]
        public string? Soyad { get; set; }
        [ForeignKey("MahkemeDosyasi")]
        public int MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
