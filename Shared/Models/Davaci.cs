using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Davaci
    {
        public int DavaciId { get; set; }

        [Required(ErrorMessage = "Ad girilmesi zorunludur.")]
        [Display(Name = "Davacı Adı")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyadı girilmesi zorunludur.")]
        [Display(Name = "Davacı Soyadı")]
        public string Soyad { get; set; }
        [Display(Name = "Davacı Doğum Tarihi")]
        public DateOnly? DogumTarihi { get; set; }

        [Required(ErrorMessage = "Davacı dilekçe özeti girilmesi zorunludur.")]
        [Display(Name = "Davacı Dilekçe Özeti")]
        public string DilekceOzeti { get; set; }

        [Display(Name = "Dava Tarihi")]
        public DateOnly? DavaTarihi { get; set; }
        [Display(Name = "İşe Giriş Tarihi")]
        public DateOnly? IseGirisTarihi { get; set; }
        [Display(Name = "İşten Çıkış Tarihi")]
        public DateOnly? IstenCikisTarihi { get; set; }
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
        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Haftalık Çalışma Günü")]
        public int? HaftalikCalismaGunu { get; set; }
        [Display(Name = "Haftalık Tatil Günü")]
        public int? HaftalikTatilGunu { get; set; }

        [Display(Name = "Günlük Çalışma Saati")]
        public TimeSpan? GunlukCalismaSaati { get; set; }
        [Display(Name = "Haftalık Çalışma Ek Süresi")]
        public TimeSpan? HaftalikEkCalismaSuresi { get; set; }

        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
        public virtual List<OdemeTalebi>? OdemeTalepleri { get; set; } = new List<OdemeTalebi>();
    }
}
