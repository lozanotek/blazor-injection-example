using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;


using BlazorApp1.Services;

namespace BlazorApp1.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[] forecasts;

        [Inject]
        protected IWeatherService Service {get; set; }


        protected override async Task OnInitializedAsync()
        {
            forecasts = await Service
                .GetWeatherForecasts()
                .ConfigureAwait(false);
        }
    }
}
