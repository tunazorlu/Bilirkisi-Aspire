using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilirkisiAspire.Shared.Models
{
    public class UcretHesaplama
    {
        [Key]
        public int UcretHesaplamaId { get; set; }
        [Display(Name = "Meslek Kodu")]
        public string? MeslekKodu { get; set; }
        [Display(Name = "Aylık Ortalama Ücret")]
        public string? AylikOrtalamaUcret { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Temel Ücret")]
        public decimal? TemelUcret { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Yemek Ücreti")]
        public decimal? YemekUcreti { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = " Elle Girilen Yemek Ücreti")]
        public decimal? ElleGirilenYemekUcreti { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Elle Girilen Yol Ücreti")]
        public decimal? ElleGirilenYolUcreti { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Yol Ücreti")]
        public decimal? YolUcreti { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Prim")]
        public decimal? Prim { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Giydirilmiş Ücret")]
        public decimal? GiydirilmisUcret { get; set; }
        [Display(Name = "Asgari Ücret Katsayı Al")]
        public bool AsgariUcretKatsayiAl { get; set; }
        [Display(Name = "Ücret Bordrolarında Hesapla")]
        public bool UcretBordrolarindaHesapla { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
