# Weather Forecast 🌤️

**WeatherForecast** is a simple ASP.NET Core MVC application that allows users to check current weather conditions for cities around the world. It consumes data from the OpenWeather API via the RapidAPI platform.

---

## Features

- Search weather forecast by city name.
- Display city name, temperature (converted to Celsius), wind speed and weather description.
- Error handling for invalid input or API limitations.
- Form validation with error messages.
- Simple and responsive user interface with Bootstrap styling.

---

## Technologies Used

- C# / ASP.NET Core MVC
- Razor Pages
- Bootstrap & Bootstrap Icons
- RapidAPI (OpenWeather API)

---

## How to Run

1. Clone the repository.
2. Before running, make sure to:
  - Subscribe to required API on Rapid API *(https://rapidapi.com/worldapi/api/open-weather13)*
  - Replace the `x-rapidapi-key` value in `WeatherForecastService.cs` with your own API key from RapidAPI.
    
    ```csharp
    { "x-rapidapi-key", "---ENTER YOUR RAPID API KEY HERE---" }
    ```
    
3. Run the application and navigate to `https://localhost:{port}` in your browser.

---

## Notes

- The application includes input validation — users must enter a valid city name using only letters and spaces.
- If the API request limit is reached, the user will receive a message:  
  `"Too Many requests for API. Try again later!"`
- The application uses dependency injection for the weather service and follows a clean separation of concerns.

---
