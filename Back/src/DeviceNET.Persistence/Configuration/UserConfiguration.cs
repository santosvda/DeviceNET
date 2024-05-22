using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceNET.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceNET.Persistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Login).HasMaxLength(100);
            builder.Property(p => p.Password).HasMaxLength(20);
            builder.Property(p => p.Email).HasMaxLength(100);

            builder.HasIndex(p => p.Login).IsUnique(true);
        }
    }   
}