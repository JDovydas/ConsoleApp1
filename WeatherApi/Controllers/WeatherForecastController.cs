using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using WeatherApi.Services;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        [HttpGet("GetWeather")]
        public async Task<IActionResult> GetWeather([FromQuery] string city)
        {
            _logger.LogInformation("Retrieving weather information for {city}", city);

            try
            {
                var weatherData = await _weatherService.GetWeather(city);
                if (weatherData != null)
                {
                    return Ok(weatherData);
                }
                else
                {
                    return NotFound($"Weather data not found for {city}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving weather information for {city}", city);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
