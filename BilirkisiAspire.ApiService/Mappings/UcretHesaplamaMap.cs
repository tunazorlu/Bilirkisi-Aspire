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
            builder.Property(t => t.TemelUcret).HasMaxLength(9);
            builder.Property(t => t.ElleGirilenYemekUcreti).HasMaxLength(9);
            builder.Property(t => t.ElleGirilenYolUcreti).HasMaxLength(9);
            builder.Property(t => t.YemekUcreti).HasMaxLength(9);
            builder.Property(t => t.YolUcreti).HasMaxLength(9);
            builder.Property(t => t.Prim).HasMaxLength(9);
            builder.Property(t => t.GiydirilmisUcret).HasMaxLength(9);
            builder.HasOne(t => t.MahkemeDosyasi).WithOne(t => t.UcretHesaplama).HasForeignKey<MahkemeDosyasi>(t => t.UcretHesaplamaId);
        }
    }
}
