using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class MuzekkereMap : IEntityTypeConfiguration<Muzekkere>
    {
        public void Configure(EntityTypeBuilder<Muzekkere> builder)
        {
            builder.HasKey(t => t.MuzekkereId);
            builder.Property(t => t.MuzekkereId).ValueGeneratedOnAdd();
            builder.HasOne(t => t.MahkemeDosyasi).WithMany(t=> t.Muzekkereler).HasForeignKey(t=>t.MahkemeDosyasiId);
        }
    }
}
