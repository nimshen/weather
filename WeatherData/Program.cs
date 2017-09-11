using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService;

namespace WeatherProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //service
            IWeatherDataService service = WeatherDataServiceFactory.GetWeatherDataService(WeatherDataServiceFactory.WeatherService.OPEN_WEATHER_MAP);

            //location testing
            Location location;
            string city;

            Console.Write("Please enter the name of the city for temp info: ");
            city = Console.ReadLine();
            if (city == "0")
            {
                return;
            }
            location = new Location(city);

            WeatherData weatherService = service.GetWeatherData(location);

            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
        }
    }
}
