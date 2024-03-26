namespace LittleDay.Models
{
    public record LatLng(double Latitude, double Longitude, double? Altitude);
    public record NewWeatherForecastQueryCommand(
                                          LatLng LatLng,
                                          double TemperaturaCelsius,
                                          double Umidade,
                                          double VelocidadeVento);
}