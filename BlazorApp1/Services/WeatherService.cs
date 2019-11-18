using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient httpClient;

        public WeatherService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetWeatherForecasts()
        {
            var forecasts = await httpClient
                .GetJsonAsync<WeatherForecast[]>("sample-data/weather.json")
                .ConfigureAwait(false);

            return forecasts;
        }

    }
}
