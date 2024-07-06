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
            builder.Property(t => t.TemelUcret).HasMaxLength(9);
            builder.Property(t => t.YemekUcreti).HasMaxLength(9);
            builder.Property(t => t.YolUcreti).HasMaxLength(9);
            builder.Property(t => t.Prim).HasMaxLength(9);
            builder.Property(t => t.Ikramiye).HasMaxLength(9);
            builder.Property(t => t.DigerOdemeler).HasMaxLength(9);
            builder.Property(t => t.HaftalikCalismaGunu).HasMaxLength(9);
            builder.HasOne(t => t.MahkemeDosyasi).WithMany(t=> t.Taniklar).HasForeignKey(t=>t.MahkemeDosyasiId);
        }
    }
}
