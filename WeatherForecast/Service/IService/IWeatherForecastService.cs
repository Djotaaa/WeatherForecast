using WeatherForecast.Models.Dto;

namespace WeatherForecast.Service.IService
{
    public interface IWeatherForecastService
    {
        Task<OpenWeatherAPIDTO> GetWeatherInfo(string city);
    }
}
