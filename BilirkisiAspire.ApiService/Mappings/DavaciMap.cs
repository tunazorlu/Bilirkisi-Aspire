using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class DavaciMap : IEntityTypeConfiguration<Davaci>
    {
        public void Configure(EntityTypeBuilder<Davaci> builder)
        {
            builder.HasKey(t => t.DavaciId);
            builder.Property(t => t.DavaciId).ValueGeneratedOnAdd();
            builder.Property(t => t.Ad).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Soyad).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Ad).IsRequired();
            builder.Property(t => t.Soyad).IsRequired();
            builder.Property(t => t.DilekceOzeti).IsRequired();
            builder.Property(t => t.TemelUcret).HasColumnType("decimal(9,2)");
            builder.Property(t => t.YemekUcreti).HasColumnType("decimal(9,2)");
            builder.Property(t => t.YolUcreti).HasColumnType("decimal(9,2)");
            builder.Property(t => t.Prim).HasColumnType("decimal(9,2)");
            builder.Property(t => t.Ikramiye).HasColumnType("decimal(9,2)");
            builder.Property(t => t.DigerOdemeler).HasColumnType("decimal(9,2)");
            builder.Property(t => t.CreatedDate).IsRequired();
            builder.Property(t => t.ModifiedDate).IsRequired();
            builder.Property(t => t.IsDeleted).IsRequired();
            builder.Property(t => t.IsActive).IsRequired();
            builder.HasMany(t => t.OdemeTalepleri).WithOne(t => t.Davaci).HasForeignKey(t => t.DavaciId);
            builder.ToTable("Davacilar");
        }
    }
}
