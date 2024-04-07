using Newtonsoft.Json;

namespace WeatherApi.Models
{

    public class Weather
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<WeatherDay> Days { get; set; }

        [JsonProperty("resolvedAddress")]
        public string ResolvedAddress { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class WeatherDay
    {
        public int Id { get; set; }
        [JsonProperty("datetime")]
        public DateTime DateTime { get; set; }

        [JsonProperty("tempmax")]
        public double TempMax { get; set; }

        [JsonProperty("tempmin")]
        public double TempMin { get; set; }

    }

}
