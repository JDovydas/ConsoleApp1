namespace WeatherApi.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public double Temperature { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
    }
}
