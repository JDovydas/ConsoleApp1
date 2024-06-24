using Newtonsoft.Json;

namespace WeatherApi.DTO
{
    public class WeatherDto
    {
        [JsonProperty("queryCost")]
        public int QueryCost { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("resolvedAddress")]
        public string ResolvedAddress { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("currentConditions")]
        public CurrentConditions CurrentConditions { get; set; }


    }

    public class CurrentConditions
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("datetimeEpoch")]
        public int DatetimeEpoch { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }



    }
}
