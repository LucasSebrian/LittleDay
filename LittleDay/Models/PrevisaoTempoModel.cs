using System.Text.Json.Serialization;

namespace LittleDay.Models
{
    public class WeatherForecastModel

    {
        [JsonPropertyName("probabilidade")]
        public int Probabilidade { get; set; }

        [JsonPropertyName("vai_chuver")]
        public bool VaiChuver { get; set; }

        [JsonPropertyName("discriminacao")]
        public string Discriminicao { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("introTitle")]
        public string IntroTitle { get; set; }
    }
}
