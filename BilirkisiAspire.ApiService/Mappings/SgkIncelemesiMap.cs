using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class SgkIncelemesiMap : IEntityTypeConfiguration<SgkIncelemesi>
    {
        public void Configure(EntityTypeBuilder<SgkIncelemesi> builder)
        {
            builder.HasKey(t => t.SgkIncelemesiId);
            builder.Property(t => t.SgkIncelemesiId).ValueGeneratedOnAdd();
            builder.HasOne(t => t.MahkemeDosyasi).WithMany(t=> t.SgkIncelemeleri).HasForeignKey(t=>t.MahkemeDosyasiId);
            builder.HasMany(t => t.EksikGunBildirimleri).WithOne(t => t.SgkIncelemesi).HasForeignKey(t => t.SgkIncelemesiId);
        }
    }
}
