using CRUD_Methods.Interfaces;
using CRUD_Methods.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Methods.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherRepository _weatherRepository;

    public WeatherForecastController(IWeatherRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }

    /* Get all the weather forecast elements */
    [HttpGet("GetAllWeatherForecasts")]
    public ActionResult<List<WeatherForecast>> Get()
    {
        return Ok(_weatherRepository.GetWeatherForecast());
    }
    
    [HttpGet("GetByName/{name}")]
    public ActionResult<WeatherForecast> GetByName(string name)
    {
        return Ok(_weatherRepository.GetWeatherForecastByName(name));
    }

    [HttpGet("GetById/{id}")]
    public ActionResult<WeatherForecast> GetById(string id)
    {
        return Ok(_weatherRepository.GetWeatherForecastById(id));
    }

    [HttpPost(Name = "AddWeatherForecast")]
    public ActionResult AddForecast(WeatherForecast wf)
    {
        _weatherRepository.AddWeatherForecast(wf);
        return Ok();
    }






}