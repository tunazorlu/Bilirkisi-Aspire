using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class UcretHesaplamaMap : IEntityTypeConfiguration<UcretHesaplama>
    {
        public void Configure(EntityTypeBuilder<UcretHesaplama> builder)
        {
            builder.HasKey(t => t.UcretHesaplamaId);
            builder.Property(t => t.UcretHesaplamaId).ValueGeneratedOnAdd();
            builder.Property(t => t.TemelUcret).HasColumnType("decimal(9,2)");
            builder.Property(t => t.ElleGirilenYemekUcreti).HasColumnType("decimal(9,2)");
            builder.Property(t => t.ElleGirilenYolUcreti).HasColumnType("decimal(9,2)");
            builder.Property(t => t.YemekUcreti).HasColumnType("decimal(9,2)");
            builder.Property(t => t.YolUcreti).HasColumnType("decimal(9,2)");
            builder.Property(t => t.Prim).HasColumnType("decimal(9,2)");
            builder.Property(t => t.GiydirilmisUcret).HasColumnType("decimal(9,2)");
            builder.HasOne(t => t.MahkemeDosyasi).WithOne(t => t.UcretHesaplama).HasForeignKey<MahkemeDosyasi>(t => t.UcretHesaplamaId);
        }
    }
}
