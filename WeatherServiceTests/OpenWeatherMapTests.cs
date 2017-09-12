using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService.Tests
{
    [TestClass()]
    public class OpenWeatherMapTests
    {
        [TestMethod()]
        public void GetWeatherDataTest()
        {
            Location location = new Location("aaaaaaaaaaaaaaaaaaa");
            IWeatherDataService service = OpenWeatherMap.Instance;
            Assert.AreNotEqual(null, service.GetWeatherData(location));
        }
    }
}