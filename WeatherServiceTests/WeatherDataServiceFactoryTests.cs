﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService.Tests
{
    [TestClass()]
    public class WeatherDataServiceFactoryTests
    {
        [TestMethod()]
        public void GetWeatherDataServiceTest()
        {

            OpenWeatherMap weatherServiceTester = OpenWeatherMap.Instance;
            Assert.AreEqual(WeatherDataServiceFactory.GetWeatherDataService(WeatherDataServiceFactory.WeatherService.OPEN_WEATHER_MAP).GetType().Name, weatherServiceTester.GetType().Name);
        }
    }
}