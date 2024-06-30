namespace BilirkisiAspire.Shared.Models
{
    public class DavaliVekili
    {
        public int DavaliVekiliId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public int MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
