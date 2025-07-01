using System.ComponentModel.DataAnnotations;

namespace WeatherForecast.Models.View
{
    public class WeatherForecastVM
    {
        [Required(ErrorMessage = "You must enter the name of the city so we can send you the information!")]
        [RegularExpression("^[a-zA-ZšđčćžŠĐČĆŽ ]+$", ErrorMessage = "You did not enter the name correctly!")]
        public string City { get; set; }
    }
}
