﻿using Microsoft.Extensions.Configuration;

namespace OdeToVeggie.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay(); 
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetMessageOfTheDay()
        {
            return "Hello " + _configuration["Name"] + "!";
        }
    }
}