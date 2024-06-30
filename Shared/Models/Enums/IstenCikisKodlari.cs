using System.ComponentModel.DataAnnotations;

namespace BilirkisiAspire.Shared.Models.Enums
{
    public enum IstenCikisKodlari
    {
        [Display(Name = "01 - Deneme süreli iş sözleşmesinin işverence feshi")]
        Bir,
        [Display(Name = "02 - Deneme süreli iş sözleşmesinin işçi tarafından feshi")]
        İki,
        [Display(Name = "03 - Belirsiz süreli iş sözleşmesinin işçi tarafından feshi (istifa)")]
        Üç,
        [Display(Name = "04 - Belirsiz süreli iş sözleşmesinin işveren tarafından haklı sebep bildirilmeden feshi")]
        Dört,
        [Display(Name = "05 - Belirli süreli iş sözleşmesinin sona ermesi")]
        Beş,
        [Display(Name = "08 - Emeklilik (yaşlılık) veya toptan ödeme nedeniyle")]
        Sekiz,
        [Display(Name = "09 - Malulen emeklilik nedeniyle")]
        Dokuz,
        [Display(Name = "10 - Ölüm")]
        On,
        [Display(Name = "11 - İş kazası sonucu ölüm")]
        Onbir,
        [Display(Name = "12 - Askerlik")]
        Oniki,
        [Display(Name = "13 - Kadın işçinin evlenmesi")]
        Onüç,
        [Display(Name = "14 - Emeklilik için yaş dışında diğer şartların tamamlanması")]
        Ondört,
        [Display(Name = "15 - Toplu işçi çıkarma")]
        Onbeş,
        [Display(Name = "16 - Sözleşme sona ermeden sigortalının aynı işverene ait diğer işyerine nakli")]
        Onaltı,
        [Display(Name = "17 - İşyerinin kapanması")]
        Onyedi,
        [Display(Name = "18 - İşin sona ermesi")]
        Onsekiz,
        [Display(Name = "19 - Mevsim bitimi (İş akdinin askıya alınması halinde kullanılır. Tekrar başlatılmayacaksa “4” nolu kod kullanılır)")]
        Ondokuz,
        [Display(Name = "20 - Kampanya bitimi (İş akdinin askıya alınması halinde kullanılır. Başlatılmayacaksa “4” nolu kod kullanılır)")]
        Yirmi,
        [Display(Name = "21 - Statü değişikliği")]
        Yirmibir,
        [Display(Name = "22 - Diğer nedenler")]
        Yirmiiki,
        [Display(Name = "23 - İşçi tarafından zorunlu nedenle fesih")]
        Yirmiüç,
        [Display(Name = "24 - İşçi tarafından sağlık nedeniyle fesih")]
        Yirmidört,
        [Display(Name = "25 - İşçi tarafından işverenin ahlak ve iyiniyet kurallarına aykırı davranış nedeni ile fesih")]
        Yirmibeş,
        [Display(Name = "26 - Disiplin Kurulu kararı ile fesih")]
        Yirmialtı,
        [Display(Name = "27 - İşveren tarafından zorunlu nedenlerle ve tutukluluk nedeniyle fesih")]
        Yirmiyedi,
        [Display(Name = "28 - İşveren tarafından sağlık nedeni ile fesih")]
        Yirmisekiz,
        [Display(Name = "29 - İşveren tarafından işçinin ahlak ve iyiniyet kurallarına aykırı davranışı nedeni ile fesih")]
        Yirmidokuz,
        [Display(Name = "30 - Vize süresinin bitimi (İş akdinin askıya alınması halinde kullan Tekrar başlatılmayacaksa “4” nolu kod kullanılır)")]
        Otuz,
        [Display(Name = "31 - Borçlar Kanunu, Sendikalar Kanunu, Grev ve Lokavt Kanunu kapsamında kendi istek ve kusuru dışında fesih")]
        Otuzbir,
        [Display(Name = "32 - 4046 sayılı Kanunun 21. maddesine göre özelleştirme nedeni ile feshi")]
        Otuziki,
        [Display(Name = "33 - Gazeteci tarafından sözleşmenin feshiü")]
        Otuzüç,
        [Display(Name = "34 - İşyerinin devri, işin veya işyerinin niteliğinin değişmesi nedeniyle fesih")]
        Otuzdört,
        [Display(Name = "35 - 6495 SK nedeniyle devlet memurluğuna geçenler")]
        Otuzbeş,
        [Display(Name = "36 - KHK ile işyerinin kapatılması")]
        Otuzaltı,
        [Display(Name = "37 - KHK ile kamu görevinden çıkarma")]
        Otuzyedi,
        [Display(Name = "38 - Doğum Nedeniyle İşten Ayrılma")]
        Otuzsekiz,
        [Display(Name = "39 - 696 KHK ile kamu işçiliğine geçiş")]
        Otuzdokuz,
        [Display(Name = "40 - 696 KHK ile kamu işçiliğine geçilememesi sebebiyle çıkış")]
        Kırk,
        [Display(Name = "41 - Re’sen işten ayrılış bildirgesi düzenlenenler (SGK tarafından değişik gerekçeler nedeniyle  işten ayrılışları re’sen düzenlenenler için seçilecek koddur.)")]
        Kırkbir,
        [Display(Name = "42 - 4857 sayılı Kanun Madde 25-II-a İş sözleşmesi yapıldığı sırada bu sözleşmenin esaslı noktalarından biri için gerekli vasıflar veya şartlar kendisinde bulunmadığı halde bunların kendisinde bulunduğunu ileri sürerek, yahut gerçeğe uygun olmayan bilgiler veya sözler söyleyerek işçinin işvereni yanıltması.")]
        Kırkiki,
        [Display(Name = "43 - 4857 sayılı Kanun Madde 25-II-b İşçinin, işveren yahut bunların aile üyelerinden birinin şeref ve namusuna dokunacak sözler sarfetmesi veya davranışlarda bulunması, yahut işveren hakkında şeref ve haysiyet kırıcı asılsız ihbar ve isnadlarda bulunması.")]
        Kırküç,
        [Display(Name = "44 - 4857 sayılı Kanun Madde 25-II-c İşçinin işverenin başka bir işçisine cinsel tacizde bulunması.")]
        Kırkdört,
        [Display(Name = "45 - 4857 sayılı Kanun Madde 25-II-d İşçinin işverene yahut onun ailesi üyelerinden birine yahut işverenin başka işçisine sataşması, işyerine sarhoş yahut uyuşturucu madde almış olarak gelmesi ya da işyerinde bu maddeleri kullanması.")]
        kırkbeş,
        [Display(Name = "46 - 4857 sayılı Kanun Madde 25-II-e İşçinin, işverenin güvenini kötüye kullanmak, hırsızlık yapmak, işverenin meslek sırlarını ortaya atmak gibi doğruluk ve bağlılığa uymayan davranışlarda bulunması.")]
        Kırkaltı,
        [Display(Name = "47 - 4857 sayılı Kanun Madde 25-II-f İşçinin, işyerinde, yedi günden fazla hapisle cezalandırılan ve cezası ertelenmeyen bir suç işlemesi.")]
        Kırkyedi,
        [Display(Name = "48 - 4857 sayılı Kanun Madde 25-II-g İşçinin işverenden izin almaksızın veya haklı bir sebebe dayanmaksızın ardı ardına iki işgünü veya bir ay içinde iki defa herhangi bir tatil gününden sonraki iş günü, yahut bir ayda üç işgünü işine devam etmemesi.")]
        Kırksekiz,
        [Display(Name = "49 - 4857 sayılı Kanun Madde 25-II-h İşçinin yapmakla ödevli bulunduğu görevleri kendisine hatırlatıldığı halde yapmamakta ısrar etmesi.")]
        Kırkdokuz,
        [Display(Name = "50 - 4857 sayılı Kanun Madde 25-II-ı İşçinin kendi isteği veya savsaması yüzünden işin güvenliğini tehlikeye düşürmesi, işyerinin malı olan veya malı olmayıp da eli altında bulunan makineleri, tesisatı veya başka eşya ve maddeleri otuz günlük ücretinin tutarıyla ödeyemeyecek derecede hasara ve kayba uğratması.")]
        Elli,
    }
}
