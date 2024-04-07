using WeatherApi.Models;
using WeatherApi.Repositories;


namespace WeatherApi.Repositories

{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly WeatherContext _context;

        public WeatherRepository(WeatherContext context)
        {
            _context = context;
        }

        //public IEnumerable<Weather> GetAll()
        //{
        //    return _context.WeatherModels;
        //}

        public void SaveWeather(Weather weather)
        {
            _context.Weather.Add(weather);
            _context.SaveChanges();
        }
    }
}
