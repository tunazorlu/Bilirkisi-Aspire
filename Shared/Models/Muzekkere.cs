using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilirkisiAspire.Shared.Models
{
    public class Muzekkere
    {
        [Key]
        public int? MuzekkereId { get; set; }
        public string? YazilanKurum { get; set; }
        public string? BildirilenUcret { get; set; }
        public int MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
