using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class TanikMap : IEntityTypeConfiguration<Tanik>
    {
        public void Configure(EntityTypeBuilder<Tanik> builder)
        {
            builder.HasKey(t => t.TanikId);
            builder.Property(t => t.TanikId).ValueGeneratedOnAdd();
            builder.Property(t => t.TemelUcret).HasColumnType("decimal(9,2)");
            builder.Property(t => t.YemekUcreti).HasColumnType("decimal(9,2)");
            builder.Property(t => t.YolUcreti).HasColumnType("decimal(9,2)");
            builder.Property(t => t.Prim).HasColumnType("decimal(9,2)");
            builder.Property(t => t.Ikramiye).HasColumnType("decimal(9,2)");
            builder.Property(t => t.DigerOdemeler).HasColumnType("decimal(9,2)");
            builder.Property(t => t.HaftalikCalismaGunu).HasMaxLength(2);
            builder.HasOne(t => t.MahkemeDosyasi).WithMany(t=> t.Taniklar).HasForeignKey(t=>t.MahkemeDosyasiId);
        }
    }
}
