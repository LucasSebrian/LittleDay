using LittleDay.Models;

namespace LittleDay.Services
{
    public interface ILittleDayService
    {
        Task<WeatherForecastModel> NovaPrevisaoTempo(string token, NewWeatherForecastQueryCommand request);
        Task<List<WeatherHistory>> Historico(string token);
    }
}