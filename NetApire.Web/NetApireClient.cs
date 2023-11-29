using NetAspire.Web.Components.Pages;

namespace NetAspire.Web
{
    public class NetApireClient
    {
        private readonly HttpClient _httpClient;

        public NetApireClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Weather.WeatherForecast[]?> GetWeatherForecastsAsync() =>
            await _httpClient.GetFromJsonAsync<Weather.WeatherForecast[]?>("weatherForecast");
    }
}
