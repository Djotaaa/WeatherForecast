using System.ComponentModel.DataAnnotations;

namespace WeatherForecast.Models.View
{
    public class WeatherForecastVM
    {
        [Required(ErrorMessage = "Morate uneti ime grada kako bismo vam poslali informacije!")]
        [RegularExpression("^[a-zA-ZšđčćžŠĐČĆŽ ]+$", ErrorMessage = "Niste uneli ime pravilno!")]
        public string City { get; set; }
    }
}
