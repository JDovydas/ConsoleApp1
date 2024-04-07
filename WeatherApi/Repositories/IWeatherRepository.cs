using WeatherApi.Models;

namespace WeatherApi.Repositories
{
    public interface IWeatherRepository
    {
        //public IEnumerable<Weather> GetAll();
        void SaveWeather(Weather weather);
    }
}

