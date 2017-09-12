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
            //data
            WeatherData weatherService = null;

            //location testing
            Location location;
            string city;

            while (true)
            {
                Console.Write("Please enter the name of the city for temp info or type exit: ");
                city = Console.ReadLine();
                if (city == "exit" || city == "EXIT" || city == "Exit")
                {
                    return;
                }
                location = new Location(city);

                try
                {
                    weatherService = service.GetWeatherData(location);
                }
                catch (WeatherDataServiceException e) { Console.WriteLine(e); }
                
                if (weatherService != null)
                {
                    //ConsoleLog messages
                    //location
                    Console.WriteLine("\nLocation: " + weatherService.name + " (" + weatherService.coord.lon + "," + weatherService.coord.lat + ")");

                    //temp
                    Console.WriteLine("Temprature: " + weatherService.main.temp + " (min: " + weatherService.main.temp_min + ", max:" + weatherService.main.temp_max + ")");

                    //humidity and pressure
                    Console.WriteLine("Humidity: " + weatherService.main.humidity + ", Pressure: " + weatherService.main.pressure);

                    //wind and description
                    Console.WriteLine("Wind: " + weatherService.wind.speed + "\nWeather Description: " + weatherService.weather[0].description);
                }
                else
                {
                    Console.WriteLine("\nLocation not found!");
                }
                
                Console.WriteLine("\nPress any key to continue...\n");
                Console.ReadKey();
            }
        }
    }
}
