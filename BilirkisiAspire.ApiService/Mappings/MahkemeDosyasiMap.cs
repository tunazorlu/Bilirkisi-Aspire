using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class MahkemeDosyasiMap : IEntityTypeConfiguration<MahkemeDosyasi>
    {
        public void Configure(EntityTypeBuilder<MahkemeDosyasi> builder)
        {
            builder.HasKey(t => t.MahkemeDosyasiId);
            builder.Property(t => t.MahkemeDosyasiId).ValueGeneratedOnAdd();
            builder.Property(t => t.DosyaYili).HasMaxLength(4);
            builder.Property(t => t.EsasNo).HasMaxLength(9);
            builder.Property(t => t.MahkemeSayisi).HasMaxLength(5);
            builder.Property(t => t.MahkemeIli).HasMaxLength(20);
            builder.HasMany(t => t.Davalilar).WithOne(t => t.MahkemeDosyasi).HasForeignKey(t => t.MahkemeDosyasiId);
            builder.HasMany(t => t.DavaciVekilleri).WithOne(t => t.MahkemeDosyasi).HasForeignKey(t => t.MahkemeDosyasiId);
            builder.HasMany(t => t.DavaliVekilleri).WithOne(t => t.MahkemeDosyasi).HasForeignKey(t => t.MahkemeDosyasiId);
            builder.HasOne(t => t.Davaci).WithOne(t => t.MahkemeDosyasi).HasForeignKey<Davaci>(t => t.DavaciId);

            builder.HasOne(t => t.UcretHesaplama).WithOne(t => t.MahkemeDosyasi).HasForeignKey<UcretHesaplama>(t => t.UcretHesaplamaId);
            builder.HasMany(t => t.HizmetSureleri).WithOne(t => t.MahkemeDosyasi).HasForeignKey(t => t.MahkemeDosyasiId);
            builder.HasMany(t => t.Muzekkereler).WithOne(t => t.MahkemeDosyasi).HasForeignKey(t => t.MahkemeDosyasiId);
            builder.HasMany(t => t.SgkIncelemeleri).WithOne(t => t.MahkemeDosyasi).HasForeignKey(t => t.MahkemeDosyasiId);
            builder.HasMany(t => t.Taniklar).WithOne(t => t.MahkemeDosyasi).HasForeignKey(t => t.MahkemeDosyasiId);
            builder.HasMany(t => t.UcretBordrolari).WithOne(t => t.MahkemeDosyasi).HasForeignKey(t => t.MahkemeDosyasiId);
            builder.HasMany(t => t.PuantajKayitlari).WithOne(t => t.MahkemeDosyasi).HasForeignKey(t => t.MahkemeDosyasiId);
            builder.Property(t => t.CreatedDate).IsRequired();
            builder.Property(t => t.ModifiedDate).IsRequired();
            builder.Property(t => t.IsDeleted).IsRequired();
            builder.Property(t => t.IsActive).IsRequired();
            builder.ToTable("MahkemeDosyalari");

        }
    }
}
