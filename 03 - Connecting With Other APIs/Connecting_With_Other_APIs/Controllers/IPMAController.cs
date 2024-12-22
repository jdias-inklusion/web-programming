using Connecting_With_Other_APIs.Models.IPMA;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Connecting_With_Other_APIs.Controllers;

/*
 * THIS CONTROLLER IS BASED ON THE DETAILS OF THE FOLLOWING URL
 * https://api.ipma.pt/open-data/forecast/
 */
[ApiController]
[Route("api/[controller]")]
public class IPMAController: Controller
{
    private readonly string _apiBaseUrl = "https://api.ipma.pt/open-data/forecast/";
    
    [HttpGet("GetWeatherWarnings")]
    public async Task<IActionResult> GetWeatherWarnings()
    {
        List<WeatherWarnings> weatherWarnings;
        string url = _apiBaseUrl + "warnings/warnings_www.json";

        using (var httpClient = new HttpClient())
        {
            using var response = await httpClient.GetAsync(url);
            var apiResponse = await response.Content.ReadAsStringAsync();
            weatherWarnings = JsonConvert.DeserializeObject<List<WeatherWarnings>>(apiResponse);

            return Ok(weatherWarnings);
        }
    }
    
    [HttpGet("GetDailySeaForecast")]
    public async Task<IActionResult> GetDailySeaForecast()
    {
        DailySeaForecast dailySeaForecast;
        string url = _apiBaseUrl + "oceanography/daily/hp-daily-sea-forecast-day0.json";

        using (var httpClient = new HttpClient())
        {
            using var response = await httpClient.GetAsync(url);
            var apiResponse = await response.Content.ReadAsStringAsync();
            dailySeaForecast = JsonConvert.DeserializeObject<DailySeaForecast>(apiResponse);

            return Ok(dailySeaForecast);
        }
    }
}