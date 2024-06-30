namespace BilirkisiAspire.Shared.Models
{
    public class EksikGunBildirimi : EntityBase.EntityBase 
    {
        public int? EksikGunBildirimiId { get; set; }
        public int? EksikGunBildirilenAy { get; set; }
        public int? EksikGunBildirilenYil { get; set; }
        public string? EksikGunNedeni { get; set; }
        public string? IstenCikisKodu { get; set; }
        public int SgkIncelemesiId { get; set; }
        public virtual SgkIncelemesi SgkIncelemesi { get; set; }
    }
}
