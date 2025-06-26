namespace WeatherForecast.Models.Dto
{
    public class OpenWeatherAPIDTO
    {
        public string? name { get; set; }
        public TemperatureInfoDTO? main { get; set; }
        public List<WeatherInfoDTO>? weather { get; set; }
        public WindInfoDTO? wind { get; set; }
        public string? WarningMessage { get; set; }
    }
}
