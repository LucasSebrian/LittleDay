using System.Text.Json.Serialization;

namespace LittleDay.Models
{
    public class WeatherDataResponse
    {
        [JsonPropertyName("main")]
        public Main Main { get; set; }

        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }
    }

    public class Main
    {
        [JsonPropertyName("temp")]
        public double Temp{ get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }

    public class Wind
    {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }
    }
}