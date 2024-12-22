using Microsoft.EntityFrameworkCore;

// This is a one line comment
/* This is a multiple
 line
 comment*/
namespace CRUD_Methods.Database;

public class WeatherDatabaseContext : DbContext
{
    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("WeatherDb");
    }

    public DbSet<Models.WeatherForecast> WeatherForecastItems { get; set; } = null!;
}