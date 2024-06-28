using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models
{
    public class Davali
    {
        [Key]
        public int? DavaliId { get; set; }

        [Display(Name = "Isim ya da Ünvan")]
        public string? IsimYaDaUnvan { get; set; }
        [Display(Name = "Dilekçe Özeti")]
        public string? DilekceOzeti { get; set; }
        [Display(Name = "Zaman Aşımı İtirazı")]
        public bool? ZamanAsimiItirazi { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Temel Ücret")]
        public decimal? TemelUcret { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Yemek Ücreti")]
        public decimal? YemekUcreti { get; set; }
        [Display(Name = "AÜ'den Hesapla")]
        public bool? AUdenHesapla { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Yol Ücreti")]
        public decimal? YolUcreti { get; set; }
        [Display(Name = "Yol Ücretini Toplu Taşımadan Hesapla")]
        public bool? YuTopTasHesapla { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Prim")]
        public decimal? Prim { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "İkramiye")]
        public decimal? Ikramiye { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Diğer Ödemeler")]
        public decimal? DigerOdemeler { get; set; }
        [ForeignKey("MahkemeDosyasi")]
        public int? MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
