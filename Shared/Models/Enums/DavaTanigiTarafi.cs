using System.ComponentModel.DataAnnotations;

namespace BilirkisiAspire.Shared.Models.Enums
{
    public enum DavaTanigiTarafi
    {
        [Display(Name = "Davacı Tanığı")]
        Davacı,
        [Display(Name = "Davalı Tanığı")]
        Davalı
    }

}
