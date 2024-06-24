using Newtonsoft.Json;
using WeatherApi.DTO;
using WeatherApi.Models;
using WeatherApi.Repositories;
// add resharper \
namespace WeatherApi.Services
{
    public class WeatherService : IWeatherService
    {

        private readonly ILogger<WeatherService> _logger; // Logger object for logging messages
        private readonly IHttpClientFactory _httpClientFactory; // Factory for creating HttpClient instances
        private readonly IConfiguration _configuration; //Configuration object for accessing appsettings
        private readonly IWeatherRepository _weatherRepository; // Repository interface for saving weather data

        public WeatherService(ILogger<WeatherService> logger, IHttpClientFactory httpClientFactory, IConfiguration configuration, IWeatherRepository weatherRepository)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _weatherRepository = weatherRepository;
        }

        public async Task<Weather> GetWeather(string city)
        {
            try
            {
                string apiKey = _configuration["WeatherAPI:ApiKey"];//Taken from appsettings

                //Constructs the API URL using the city parameter and the retrieved API key
                string apiUrl = $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city}?unitGroup=metric&key={apiKey}&contentType=json";

                using var httpClient = _httpClientFactory.CreateClient(); //Creates an instance of HttpClient 
                var response = await httpClient.GetAsync(apiUrl); // Sends an asynchronous GET request to the API endpoint

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync(); //Reads the raw JSON response 
                    _logger.LogInformation("Raw JSON response: {jsonString}", jsonString); // Log the raw JSON string received from the API

                    var weatherDto = JsonConvert.DeserializeObject<WeatherDto>(jsonString);
                    _logger.LogInformation("Deserialized WeatherDto object: {@weatherDto}", weatherDto);


                    var weather = new Weather
                    {
                        Temperature = weatherDto.CurrentConditions.Temp,
                        Country = weatherDto.ResolvedAddress.Split(',')[2].Trim(),
                        Region = weatherDto.ResolvedAddress.Split(',')[1].Trim()
                    };

                    _weatherRepository.SaveWeather(weather);

                    return weather;
                }
                else
                {
                    _logger.LogError("Failed to retrieve weather data for {city}. Status code: {statusCode}", city, response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving weather data for {city}", city);
                throw;
            }
        }
    }
}
