using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class DavaliVekili
    {
        [Key]
        public int DavaliVekiliId { get; set; }
        [Display(Name = "Davalı Vekili Adı")]
        public string? Ad { get; set; }
        [Display(Name = "Davalı Vekili Soyadı")]
        public string? Soyad { get; set; }
        [ForeignKey("MahkemeDosyasi")]
        public int MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
