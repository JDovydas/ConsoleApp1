using WeatherApi.Models;

namespace WeatherApi.Repositories
{
    public interface IWeatherRepository
    {
        void SaveWeather(Weather weather);
    }
}

