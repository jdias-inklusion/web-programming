using CRUD_Methods.Database;
using CRUD_Methods.Interfaces;

namespace CRUD_Methods.Models;

public class WeatherRepository : IWeatherRepository
{
    private string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    public WeatherRepository()
    {
        using (var context = new WeatherDatabaseContext())
        {
            var weatherItems = new List<WeatherForecast>
            {
                new WeatherForecast
                {
                    Id = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                    Name= "Lisbon"
                },
                new WeatherForecast
                {
                    Id = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                    Name= "Madrid"
                },
                new WeatherForecast
                {
                    Id = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                    Name= "Paris"
                },
                new WeatherForecast
                {
                    Id = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                    Name= "Berlin"
                },
                new WeatherForecast
                {
                    Id = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                    Name= "London"
                }
            };
            
            context.WeatherForecastItems.AddRange(weatherItems);
            context.SaveChanges();
        }
    }

    public List<WeatherForecast> GetWeatherForecast()
    {
        using (var context = new WeatherDatabaseContext())
        {
            var list = context.WeatherForecastItems.ToList();
            return list;
        }
    }
    
    public WeatherForecast GetWeatherForecastById(string id)
    {
        using ( var context = new WeatherDatabaseContext())
        {
            var item = 
                context.WeatherForecastItems.Find(id);
            return item;
        }
    }

    public WeatherForecast GetWeatherForecastByName(string name)
    {
        using (var context = new WeatherDatabaseContext())
        {
            var list = context.WeatherForecastItems.ToList();
            foreach (WeatherForecast item in list)
            {
                if (item.Name.Equals(name))
                {
                    return item;
                }
            }

            return null;
        }
    }

    public void AddWeatherForecast(WeatherForecast wf)
    {
        using (var context = new WeatherDatabaseContext())
        {
            context.WeatherForecastItems.Add(wf);
            context.SaveChanges();
        }
    }
}