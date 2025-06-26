using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WeatherForecast.Models.Dto;
using WeatherForecast.Service.IService;

namespace WeatherForecast.Service
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;
        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<OpenWeatherAPIDTO> GetWeatherInfo(string city)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://open-weather13.p.rapidapi.com/city?city={city}&lang=EN&units=Metric"),
                Headers =
                {
                    { "x-rapidapi-key", "f35b1d445bmsh4c70565cfaa3c0cp1883b6jsn753f75bb224b" },
                    { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
                }
            };

            using (var response = await _httpClient.SendAsync(request))
            {
                if(response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    return new OpenWeatherAPIDTO
                    {
                        name = null,
                        main = null,
                        weather = null,
                        wind = null,
                        WarningMessage = "Too Many requests for API. Try again later!"
                    };
                }
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var openWeatherAPIResponse = JsonConvert.DeserializeObject<OpenWeatherAPIDTO>(body);
               
                return openWeatherAPIResponse;
            }
        }
    }
}