using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public interface IWeatherService
    {
        Task<WeatherForecast[]> GetWeatherForecasts();
    }
}
