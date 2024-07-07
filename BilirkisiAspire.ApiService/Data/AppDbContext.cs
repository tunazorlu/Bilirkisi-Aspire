using BilirkisiAspire.ApiService.Mappings;
using BilirkisiAspire.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BilirkisiAspire.ApiService.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Davaci> Davacilar { get; set; }
        public DbSet<DavaciVekili> DavaciVekilleri { get; set; }
        public DbSet<Davali> Davalilar { get; set; }
        public DbSet<DavaliVekili> DavaliVekilleri { get; set; }
        public DbSet<EksikGunBildirimi> EksikGunBildirimleri { get; set; }
        public DbSet<HizmetSuresi> HizmetSureleri { get; set; }
        public DbSet<MahkemeDosyasi> MahkemeDosyalari { get; set; }
        public DbSet<Muzekkere> Muzekkereler { get; set; }
        public DbSet<OdemeTalebi> OdemeTalepleri { get; set; }
        public DbSet<PuantajKaydi> PuantajKayitlari { get; set; }
        public DbSet<SgkIncelemesi> SgkIncelemeleri { get; set; }
        public DbSet<Tanik> Taniklar { get; set; }
        public DbSet<UcretBordrosu> UcretBordrolari { get; set; }
        public DbSet<UcretHesaplama> UcretHesaplamalari { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
