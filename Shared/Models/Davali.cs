namespace BilirkisiAspire.Shared.Models
{
    public class Davali
    {
        public int? DavaliId { get; set; }
        public string? IsimYaDaUnvan { get; set; }
        public string? DilekceOzeti { get; set; }
        public bool? ZamanAsimiItirazi { get; set; }
        public decimal? TemelUcret { get; set; }
        public decimal? YemekUcreti { get; set; }
        public bool? AUdenHesapla { get; set; }
        public decimal? YolUcreti { get; set; }
        public bool? YuTopTasHesapla { get; set; }
        public decimal? Prim { get; set; }
        public decimal? Ikramiye { get; set; }
        public decimal? DigerOdemeler { get; set; }
        public int? MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
