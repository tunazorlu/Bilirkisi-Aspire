using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilirkisiAspire.Shared.Models
{
    public class Tanik
    {
        [Key]
        public int TanikId { get; set; }
        [Display(Name = "Tanık Adı")]
        public string? Ad { get; set; }
        [Display(Name = "Tanık Soyadı")]
        public string? Soyad { get; set; }
        [Display(Name = "Tanık Beyanı (Özet)")]
        public string? BeyanOzeti { get; set; }

        [Display(Name = "Tanığın Tarafı")]
        public string? Tarafi { get; set; }
        [Display(Name = "Tanığın Husumeti")]
        public bool? Husumet { get; set; }

        [Display(Name = "İşe Giriş Tarihi")]
        public DateTime? TaniginIseGirisTarihi { get; set; }
        [Display(Name = "İşten Çıkış Tarihi")]
        public DateTime? TaniginIstenCikisTarihi { get; set; }
        public DateTime? DavacininIseGirisSaati { get; set; }
        [Display(Name = "Davacının İşten Çıkış Saati")]
        public DateTime? DavacininIsttenCikisSaati { get; set; }
        [Display(Name = "Davacının aftalık Ek Calışma Süresi")]
        public TimeSpan? HaftalikEkCalismaSure { get; set; }
        [Display(Name = "Temel Ücret")]
        public decimal? TemelUcret { get; set; }
        [Display(Name = "Yemek Ücreti")]
        public decimal? YemekUcreti { get; set; }
        [Display(Name = "AÜ'den Hesapla")]
        public bool? AUdenHesapla { get; set; }
        [Display(Name = "Yol Ücretini Toplu Taşımadan Hesapla")]
        public bool? YuTopTasHesapla { get; set; }
        [Display(Name = "Yol Ücreti")]
        public decimal? YolUcreti { get; set; }
        [Display(Name = "Prim")]
        public decimal? Prim { get; set; }
        [Display(Name = "İkramiye")]
        public decimal? Ikramiye { get; set; }
        [Display(Name = "Diğer Ödemeler")]
        public decimal? DigerOdemeler { get; set; }
        [Display(Name = "Haftalık Çalışma Günü")]
        public int? HaftalikCalismaGunu { get; set; }
        [Display(Name = "Hafta Tatil Günü")]
        public int? HaftaTatiliGunu { get; set; }
        public int MahkemeDosyasiId { get; set; }
        public MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
