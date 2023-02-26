using DItask.Interface;
using DItask.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Xml;

namespace DItask.Classes
{
    public class WeatherService:IWeatherService
    {
       

        public WeatherData ReturnWeatherData(string cityName)
        {
            return new WeatherData() {
                Name = cityName,
                Temperature = new Random().Next(0, 100)
            };
        }

        
    }
}
