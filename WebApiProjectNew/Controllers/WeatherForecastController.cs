using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApiProjectNew.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly List<WeatherForecast> _forecasts;

        static WeatherForecastController()
        {
            _forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = new Random().Next(-20, 55),
                Summary = Summaries[new Random().Next(Summaries.Length)]
            }).ToList();
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetAll()
        {
            return _forecasts;
        }

        [HttpGet("{dateOnly}")]
        public IEnumerable<WeatherForecast> GetByDate(DateTime date)
        {
            return _forecasts.Where(x => x.Date == DateOnly.FromDateTime(date));
        }

        [HttpPost]
        public void Post(WeatherForecast newForecast)
        {
            _forecasts.Add(newForecast);

        }

        [HttpDelete("{dateOnly}")]
        public void DeleteWeatherForecast(DateTime date)
        {
            _forecasts.Remove(_forecasts.FirstOrDefault(x => x.Date == DateOnly.FromDateTime(date)));

        }

        [HttpDelete]
        public void DeleteAllWeatherForecasts()
        {
            _forecasts.Clear();

        }

    }
}
















