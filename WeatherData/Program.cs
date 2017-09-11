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

            Console.Write("Please enter the name of the city for temp info or type exit: ");
            city = Console.ReadLine();
            if (city == "exit" || city == "EXIT" || city == "Exit")
            {
                return;
            }
            location = new Location(city);

            try
            {
                WeatherData weatherService = service.GetWeatherData(location);
            }
            catch (WeatherDataServiceException e) { Console.WriteLine(e); }

            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
        }
    }
}
