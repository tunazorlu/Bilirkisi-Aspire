using System.ComponentModel.DataAnnotations;

namespace BilirkisiAspire.Shared.Models.Enums
{
    public enum EksikGunNedenleri
    {
        [Display(Name = "01 - İstirahat")]
        Bir,
        [Display(Name = "03 - Disiplin Cezası")]
        Üç,
        [Display(Name = "04 - Gözaltına alınma")]
        Dört,
        [Display(Name = "05 - Tutukluluk")]
        Beş,
        [Display(Name = "06 - Kısmi istihdam")]
        Altı,
        [Display(Name = "07 - Puantaj kayıtları")]
        Yedi,
        [Display(Name = "08 - Grev")]
        Sekiz,
        [Display(Name = "09 - Lokavt")]
        Dokuz,
        [Display(Name = "10 - Genel hayatı etkileyen olaylar")]
        On,
        [Display(Name = "11 - Doğal afet")]
        Onbir,
        [Display(Name = "12 - Birden fazla")]
        Oniki,
        [Display(Name = "13 - Diğer Nedenler")]
        Onüç,
        [Display(Name = "15 - Devamsızlık")]
        Onbeş,
        [Display(Name = "16 - Fesih tarihinde çalışmamış")]
        Onaltı,
        [Display(Name = "17 - Ev hizmetlerinde 30 günden az çalışma")]
        Onyedi,
        [Display(Name = "18 - Kısa çalışma ödeneği")]
        Onsekiz,
        [Display(Name = "19 - Ücretsiz Doğum İzni")]
        Ondokuz,
        [Display(Name = "20 - Ücretsiz Yol İzni")]
        Yirmi,
        [Display(Name = "21 - Diğer Ücretsiz İzin")]
        Yirmibir,
        [Display(Name = "22 - 5434 SK. ek 76, GM 192")]
        Yirmiiki,
        [Display(Name = "23 - Yarım çalışma ödeneği")]
        Yirmiüç,
        [Display(Name = "24 - Yarım çalışma ödeneği ve diğer nedenler")]
        Yirmidört,
        [Display(Name = "25 - Diğer belge/kanun türlerinden gün tamamlama")]
        Yirmibeş,
        [Display(Name = "26 - Kısmi istihdama izin verilen yabancı uyruklu sigortalı")]
        Yirmialtı,
        [Display(Name = "27 - Kısa Çalışma Ödeneği ve Diğer Nedenler")]
        Yirmiyedi,
        [Display(Name = "28 - Pandemi Ücretsiz İzin(4857 Geç. 10. md)")]
        Yirmisekiz,
        [Display(Name = "29 - Pandemi Ücretsiz İzin(4857 Geç. 10. md) Ve Diğer")]
        Yirmidokuz,
    }
}
