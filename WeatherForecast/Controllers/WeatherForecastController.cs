using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Models.Dto;
using WeatherForecast.Models.View;
using WeatherForecast.Service.IService;

namespace WeatherForecast.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWeatherForecastService _weatherService;

        public WeatherForecastController(IWeatherForecastService weatherService)
        {
            _weatherService = weatherService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WeatherForecastPage()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult WeatherForecastPage(WeatherForecastVM model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(ShowForecastPage), new { city = model.City });
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> ShowForecastPage(string city)
        {
            var response = await _weatherService.GetWeatherInfo(city);
            if(response != null)
            {
                var model = new OpenWeatherAPIDTO
                {
                    name = response.name,
                    main = response.main,
                    weather = response.weather,
                    wind = response.wind
                };
                return View(model);
            }
            else
            {
                return View();
            }
        }
    }
}
