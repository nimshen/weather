using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    static public class WeatherDataServiceFactory
    {
        
        public static IWeatherDataService GetWeatherDataService(int openService)
        {
            IWeatherDataService weatherService = null;
            if (openService == WeatherService.OPEN_WEATHER_MAP)
            {
                weatherService = OpenWeatherMap.Instance;
            }
            
            return weatherService;
        }

        public class WeatherService
        {
            public const int OPEN_WEATHER_MAP = 1;
        }
    }
}
