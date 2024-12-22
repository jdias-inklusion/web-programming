using CRUD_Methods.Models;

namespace CRUD_Methods.Interfaces;
using CRUD_Methods.Models;

public interface IWeatherRepository
{
    public List<WeatherForecast> GetWeatherForecast();
    public WeatherForecast GetWeatherForecastById(string id);
    public WeatherForecast GetWeatherForecastByName(string name);
    public void AddWeatherForecast(WeatherForecast wf);
}