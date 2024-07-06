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

        [Display(Name = "Temel Ücret")]
        public decimal? TemelUcret { get; set; }

        [Display(Name = "Yemek Ücreti")]
        public decimal? YemekUcreti { get; set; }

        [Display(Name = " Elle Girilen Yemek Ücreti")]
        public decimal? ElleGirilenYemekUcreti { get; set; }


        [Display(Name = "Elle Girilen Yol Ücreti")]
        public decimal? ElleGirilenYolUcreti { get; set; }

        [Display(Name = "Yol Ücreti")]
        public decimal? YolUcreti { get; set; }
        [Display(Name = "Prim")]
        public decimal? Prim { get; set; }
        [Display(Name = "Giydirilmiş Ücret")]
        public decimal? GiydirilmisUcret { get; set; }
        [Display(Name = "Asgari Ücret Katsayı Al")]
        public bool AsgariUcretKatsayiAl { get; set; }
        [Display(Name = "Ücret Bordrolarında Hesapla")]
        public bool UcretBordrolarindaHesapla { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
