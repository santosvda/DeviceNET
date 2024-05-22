using DeviceNET.Domain.Models;
using DeviceNET.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DeviceNet.Persistence.Contexts
{
    public class DeviceNetContext : DbContext
    {
        public DeviceNetContext(DbContextOptions<DeviceNetContext> options) : base (options){ }
        public DbSet<User>? Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}