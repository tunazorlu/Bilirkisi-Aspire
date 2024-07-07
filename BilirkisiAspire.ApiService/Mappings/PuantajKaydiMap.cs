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
            builder.Property(t => t.FazlaCalisma).HasColumnType("decimal(9,2)");
            builder.Property(t => t.UBGT).HasColumnType("decimal(9,2)");
            builder.Property(t => t.Izin).HasColumnType("decimal(9,2)");
            builder.Property(t => t.Ay).IsRequired();
            builder.Property(t => t.Yil).IsRequired();
            builder.Property(t => t.FazlaCalisma).IsRequired();
            builder.Property(t => t.UBGT).IsRequired();
            builder.Property(t => t.Izin).IsRequired();
            builder.HasOne(t => t.MahkemeDosyasi).WithMany(t=> t.PuantajKayitlari).HasForeignKey(t=>t.MahkemeDosyasiId);
        }
    }
}
