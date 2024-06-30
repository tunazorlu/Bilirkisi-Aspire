using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilirkisiAspire.Shared.Models
{
    public class MahkemeDosyasi : EntityBase.EntityBase
    {
        public int MahkemeDosyasiId { get; set; }

        public string MahkemeIli { get; set; }

        public int MahkemeSayisi { get; set; }
        private int _year;
        public int DosyaYili
        {
            get { return _year; }
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value >= 2020 && value <= currentYear)
                {
                    _year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Dosya yılı 2020'den küçük, {currentYear} yılından büyük olamaz.");
                }
            }
        }
        public int EsasNo { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int? DavaciId { get; set; }
        public virtual Davaci? Davaci { get; set; }
        public int? UcretHesaplamaId { get; set; }
        public virtual UcretHesaplama? UcretHesaplama { get; set; }
        public virtual List<Davali>? Davalilar { get; set; } = new List<Davali>();
        public virtual List<DavaciVekili>? DavaciVekilleri { get; set; } = new List<DavaciVekili>();
        public virtual List<DavaliVekili>? DavaliVekilleri { get; set; } = new List<DavaliVekili>();
        public virtual List<HizmetSuresi>? HizmetSureleri { get; set; } = new List<HizmetSuresi>();
        public virtual List<Muzekkere>? Muzekkereler { get; set; } = new List<Muzekkere>();
        public virtual List<SgkIncelemesi>? SgkIncelemeleri { get; set; } = new List<SgkIncelemesi>();
        public virtual List<Tanik>? Taniklar { get; set; } = new List<Tanik>();
        public virtual List<UcretBordrosu>? UcretBordrolari { get; set; } = new List<UcretBordrosu>();
        public virtual List<PuantajKaydi>? PuantajKayitlari { get; set; } = new List<PuantajKaydi>();
    }
}
