using MafraaHajeeraApi.Conf;
using Microsoft.EntityFrameworkCore;

namespace MafraaHajeeraApi.Doamin;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new RegionConf());
        modelBuilder.ApplyConfiguration(new CityConf());
        modelBuilder.ApplyConfiguration(new NationalityConf());


    }
    public DbSet<Family> Families { get; set; }
    public DbSet<Mother> Mothers { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Nationality> Nationalities { get; set; }
    public DbSet<Region> Regions { get; set; }
}