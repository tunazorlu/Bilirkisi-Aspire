using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class OdemeTalebiMap : IEntityTypeConfiguration<OdemeTalebi>
    {
        public void Configure(EntityTypeBuilder<OdemeTalebi> builder)
        {
            builder.HasKey(t => t.OdemeTalebiId);
            builder.Property(t => t.OdemeTalebiId).ValueGeneratedOnAdd();
            builder.HasOne(t => t.Davaci).WithMany(t=> t.OdemeTalepleri).HasForeignKey(t=>t.DavaciId);
        }
    }
}
