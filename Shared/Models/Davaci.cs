using BilirkisiAspire.Shared.Models.EntityBase;

namespace BilirkisiAspire.Shared.Models
{
    public class Davaci : EntityBase.EntityBase
    {
        public int DavaciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string DilekceOzeti { get; set; }
        public DateTime? DavaTarihi { get; set; }
        public DateTime? IseGirisTarihi { get; set; }
        public DateTime? IstenCikisTarihi { get; set; }
        public decimal? TemelUcret { get; set; }
        public decimal? YemekUcreti { get; set; }
        public bool? AUdenHesapla { get; set; }
        public decimal? YolUcreti { get; set; }
        public bool? YuTopTasHesapla { get; set; }
        public decimal? Prim { get; set; }
        public decimal? Ikramiye { get; set; }
        public decimal? DigerOdemeler { get; set; }
        public int? HaftalikCalismaGunu { get; set; }
        public int? HaftalikTatilGunu { get; set; }
        public int? GunlukCalismaSaati { get; set; }
        public int? HaftalikEkCalismaSuresi { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
        public virtual List<OdemeTalebi>? OdemeTalepleri { get; set; } = new List<OdemeTalebi>();
    }
}
