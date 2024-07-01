using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class HizmetSuresiMap : IEntityTypeConfiguration<HizmetSuresi>
    {
        public void Configure(EntityTypeBuilder<HizmetSuresi> builder)
        {
            builder.HasKey(t => t.HizmetSuresiId);
            builder.Property(t => t.HizmetSuresiId).ValueGeneratedOnAdd();
            builder.HasOne(t => t.MahkemeDosyasi).WithMany(t=> t.HizmetSureleri).HasForeignKey(t=>t.MahkemeDosyasiId);
        }
    }
}
