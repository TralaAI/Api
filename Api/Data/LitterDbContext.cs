using Microsoft.EntityFrameworkCore;
using Api.Models.Data;
using Api.Models;

namespace Api.Data;

public class LitterDbContext(DbContextOptions<LitterDbContext> options) : DbContext(options)
{
  public DbSet<Litter> Litters { get; set; }
  public DbSet<Camera> Cameras { get; set; }
  public DbSet<ApiKey> ApiKeys { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Litter>()
        .HasOne(l => l.Camera)
        .WithMany(c => c.Litters)
        .HasForeignKey(l => l.CameraId)
        .IsRequired();

    modelBuilder.Entity<Camera>()
      .Property(c => c.Latitude)
      .HasPrecision(9, 0);

    modelBuilder.Entity<Camera>()
      .Property(c => c.Longitude)
      .HasPrecision(9, 0);
  }
}