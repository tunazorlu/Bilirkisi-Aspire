using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class EksikGunBildirimiMap : IEntityTypeConfiguration<EksikGunBildirimi>
    {
        public void Configure(EntityTypeBuilder<EksikGunBildirimi> builder)
        {
            builder.HasKey(t => t.EksikGunBildirimiId);
            builder.Property(t => t.EksikGunBildirimiId).ValueGeneratedOnAdd();
            builder.Property(t => t.EksikGunNedeni).HasMaxLength(75);
            builder.Property(t => t.IstenCikisKodu).HasMaxLength(350);
            builder.Property(t => t.CreatedDate).IsRequired();
            builder.Property(t => t.ModifiedDate).IsRequired();
            builder.Property(t => t.IsDeleted).IsRequired();
            builder.Property(t => t.IsActive).IsRequired();
            builder.HasOne(t => t.SgkIncelemesi).WithMany(t => t.EksikGunBildirimleri).HasForeignKey(t => t.EksikGunBildirimiId);
            builder.ToTable("EksikGunBildirimleri");
        }
    }
}
