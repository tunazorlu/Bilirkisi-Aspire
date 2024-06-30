using System.ComponentModel.DataAnnotations;

namespace BilirkisiAspire.Shared.Models.Enums
{
    public enum HizmetSuresiHesapYontemi
    {
        [Display(Name = "Sadece SGK Bilgilerine Göre")]
        SadeceSGKBilgilerineGöre,
        [Display(Name = "SGK ve Vekil, Tanık Beyanlarına Göre")]
        SGKveVekilTanıkBeyanlarınaGöre
    }
}
