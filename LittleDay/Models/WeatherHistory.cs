using System.Text.Json.Serialization;

namespace LittleDay.Models
{
    public class WeatherHistory
    {
        public string id { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("dataehora")]
        public DateTime DataHora { get; set; }

        [JsonPropertyName("cidade")]
        public string Cidade { get; set; }

        [JsonPropertyName("estado")]
        public string Estado { get; set; }

        [JsonPropertyName("umidade")]
        public double Umidade { get; set; }

        [JsonPropertyName("velocidade_vento")]
        public double VelocidadeVento { get; set; }

        [JsonPropertyName("altitude")]
        public double Altitude { get; set; }

        [JsonPropertyName("Temperatura_celsius")]
        public double TemperaturaCelsius { get; set; }

        [JsonPropertyName("latlng")]
        public LatLng LatLng { get; set; }

        [JsonPropertyName("resultado")]
        public Resultado Resultado { get; set; }
    }

    public class Resultado
    {
        [JsonPropertyName("probabilidade")]
        public int Probabilidade { get; set; }

        [JsonPropertyName("vai_chuver")]
        public bool VaiChuver { get; set; }

        [JsonPropertyName("discriminacao")]
        public string Discriminicao { get; set; }

        [JsonPropertyName("introTitle")]
        public string IntroTitle { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}
