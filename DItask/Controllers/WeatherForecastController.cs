using DItask.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IGreetingService _greetingService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IGreetingService greetingService)
        {
            _logger = logger;
            _greetingService = greetingService;
        }

        [HttpGet]
        public IEnumerable<string> GreeClient(string name)
        {
            return new[] { _greetingService.Greet(name) };
        }
    }
}
