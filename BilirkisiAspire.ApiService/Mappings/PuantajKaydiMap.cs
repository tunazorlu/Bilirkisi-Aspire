using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class PuantajKaydiMap : IEntityTypeConfiguration<PuantajKaydi>
    {
        public void Configure(EntityTypeBuilder<PuantajKaydi> builder)
        {
            builder.HasKey(t => t.PuantajKaydiId);
            builder.Property(t => t.PuantajKaydiId).ValueGeneratedOnAdd();
            builder.Property(t => t.FazlaCalisma).HasMaxLength(9);
            builder.Property(t => t.UBGT).HasMaxLength(9);
            builder.Property(t => t.Izin).HasMaxLength(9);
            builder.Property(t => t.Ay).IsRequired();
            builder.Property(t => t.Yil).IsRequired();
            builder.Property(t => t.FazlaCalisma).IsRequired();
            builder.Property(t => t.UBGT).IsRequired();
            builder.Property(t => t.Izin).IsRequired();
            builder.HasOne(t => t.MahkemeDosyasi).WithMany(t=> t.PuantajKayitlari).HasForeignKey(t=>t.MahkemeDosyasiId);
        }
    }
}
