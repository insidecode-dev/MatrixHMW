﻿using DItask.Interface;

namespace DItask.Classes
{
    public class GreetingService : IGreetingService
    {
        public string Greet(string name)
        {
            return $"Hello {name}!";
        }
    }
}
