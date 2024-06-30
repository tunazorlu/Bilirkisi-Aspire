using System.ComponentModel.DataAnnotations;

namespace BilirkisiAspire.Shared.Models.Enums
{
    public enum OdemeTalepSecenegi
    {
        [Display(Name = "Kıdem Tazminatı")]
        KidemTazminati,
        [Display(Name = "İhbar Tazminatı")]
        IhbarTazminati,
        [Display(Name = "Fazla Çalışma Ücreti")]
        FazlaCalismaUcreti,
        [Display(Name = "Hafta Tatili Ücreti")]
        HaftaTatiliUcreti,
        [Display(Name = "UBGT")]
        UBGT,
        [Display(Name = "Yıllık İzin Ücreti")]
        YillikIzinUcreti,
        [Display(Name = "AGİ")]
        AGI,
        [Display(Name = "Ücret")]
        Ucret,
        [Display(Name = "Diğer Alacak Beyanı")]
        DigerAlacakBeyani,
    }
}
