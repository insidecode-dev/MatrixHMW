using DItask.Classes;
using DItask.Interface;
using DItask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DItask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IGreetingService _greetingService;
        private readonly IWeatherService _weatherservice;  
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IGreetingService greetingService, IWeatherService weatherservice)
        {
            _logger = logger;
            _greetingService = greetingService; 
            _weatherservice = weatherservice;
            
        }

        //you should uncomment to use these services  

        #region Greeting
        //[HttpGet]
        //public string GreeClient(string name)
        //{
        //    return _greetingService.Greet(name);
        //}
        #endregion

        #region GetWeather
        //[HttpGet]
        //public WeatherData GetWeather(string cityName)
        //{
        //    return _weatherservice.ReturnWeatherData(cityName);
        //}
        #endregion
    }
}
