﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Muzekkere
    {
        [Key]
        public int? MuzekkereId { get; set; }

        [Display(Name = "Müzekkere Yazılan Kurum")]
        public string? YazilanKurum { get; set; }

        [Display(Name = "Müzekkere Bildirilen Ücret")]
        public string? BildirilenUcret { get; set; }

        [ForeignKey("MahkemeDosyasi")]
        public int MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
