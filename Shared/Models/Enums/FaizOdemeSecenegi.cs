using System.ComponentModel.DataAnnotations;

namespace BilirkisiAspire.Shared.Models.Enums
{
    public enum FaizOdemeSecenegi
    {
        [Display(Name = "Talep Yok")]
        TalepYok,
        [Display(Name = "Dava")]
        DavaTarihi,
        [Display(Name = "Temerrüt")]
        TemerrütTarihi,
        [Display(Name = "Sözleşme Fesih")]
        SözleşmeFesihTarihi,
        [Display(Name = "İhtarnamenin Ulaştığı")]
        İhtarnameninUlaştiğiTarih
    }
}
