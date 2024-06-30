﻿using System.Net.Mime;
using BilirkisiAspire.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BilirkisiAspire.ApiService.Mappings
{
    public class DavaliMap : IEntityTypeConfiguration<Davali>
    {
        public void Configure(EntityTypeBuilder<Davali> builder)
        {
            builder.HasKey(t => t.DavaliId);
            builder.Property(t => t.DavaliId).ValueGeneratedOnAdd();
            builder.Property(t => t.IsimYaDaUnvan).HasMaxLength(300);
            builder.Property(t => t.DilekceOzeti).HasMaxLength(10000);
            builder.Property(t => t.TemelUcret).HasMaxLength(9);
            builder.Property(t => t.YemekUcreti).HasMaxLength(9);
            builder.Property(t => t.YolUcreti).HasMaxLength(9);
            builder.Property(t => t.Prim).HasMaxLength(9);
            builder.Property(t => t.Ikramiye).HasMaxLength(9);
            builder.Property(t => t.DigerOdemeler).HasMaxLength(9);
            builder.Property(t => t.CreatedDate).IsRequired();
            builder.Property(t => t.ModifiedDate).IsRequired();
            builder.Property(t => t.IsDeleted).IsRequired();
            builder.Property(t => t.IsActive).IsRequired();
            builder.HasOne(t => t.MahkemeDosyasi).WithMany(t => t.Davalilar).HasForeignKey(t => t.DavaliId);
            builder.ToTable("Davalilar");
        }
    }
}
