using DItask.Models;
using System.Collections.Generic;

namespace DItask.Interface
{
    public interface IWeatherService
    {
        public WeatherData ReturnWeatherData(string cityName);
    }
}
