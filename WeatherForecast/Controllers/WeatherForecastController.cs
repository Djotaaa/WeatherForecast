using Microsoft.AspNetCore.Mvc;

namespace WeatherForecast.Controllers
{
    public class WeatherForecastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
