using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class UcretBordrosuMap : IEntityTypeConfiguration<UcretBordrosu>
    {
        public void Configure(EntityTypeBuilder<UcretBordrosu> builder)
        {
            builder.HasKey(t => t.UcretBordrosuId);
            builder.Property(t => t.UcretBordrosuId).ValueGeneratedOnAdd();
            builder.Property(t => t.Ucret).HasColumnType("decimal(9,2)");
            builder.Property(t => t.FazlaCalisma).HasColumnType("decimal(9,2)");
            builder.Property(t => t.UBGT).HasColumnType("decimal(9,2)");
            builder.Property(t => t.Prim).HasColumnType("decimal(9,2)");
            builder.Property(t => t.Izin).HasColumnType("decimal(9,2)");
            builder.Property(t => t.YemekUcreti).HasColumnType("decimal(9,2)");
            builder.Property(t => t.YolUcreti).HasColumnType("decimal(9,2)");
            builder.Property(t => t.Ay).IsRequired();
            builder.Property(t => t.Yil).IsRequired();
            builder.Property(t => t.Ucret).IsRequired();
            builder.Property(t => t.FazlaCalisma).IsRequired();
            builder.Property(t => t.UBGT).IsRequired();
            builder.Property(t => t.Izin).IsRequired();
            builder.Property(t => t.YemekUcreti).IsRequired();
            builder.Property(t => t.YolUcreti).IsRequired();
            builder.Property(t => t.ImzaVarYok).IsRequired();
            builder.Property(t => t.BankaDekontuVarYok).IsRequired();
            builder.HasOne(t => t.MahkemeDosyasi).WithMany(t=> t.UcretBordrolari).HasForeignKey(t=>t.MahkemeDosyasiId);
        }
    }
}
