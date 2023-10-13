using MobileApp.Models;

namespace MobileApp.Services;

class MockWeatherService : IWeatherService
{
    public async Task<List<Weather>> GetWeathersAsync()
    {
        var weathers = new List<Weather>
        {
            new Weather
            {
                Date = new DateTime(2021,11,1),
                Summary = "Rainy",
                TemperatureC = 20
            },
            new Weather
            {
                Date = new DateTime(2021,11,2),
                Summary = "Cloudy",
                TemperatureC = 25
            },
            new Weather
            {
                Date = new DateTime(2021,11,3),
                Summary = "Sunny",
                TemperatureC = 30
            }
        };

        return weathers;
    }
}
