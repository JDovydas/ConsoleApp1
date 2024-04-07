namespace WeatherApi
{
    public static class IHttpClientExtension
    {
        public static async Task<T> ReadAsJsonAsync<T>(this HttpContent content)  ///extension method for the HttpContent class
        {
            var jsonString = await content.ReadAsStringAsync(); // asynchronously reads the content of the HttpContent object passed as an argument and converts it to a string.
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonString); // Deserializes the JSON string obtained from the HttpContent into an object of type T using JsoN
        }
    }
}
