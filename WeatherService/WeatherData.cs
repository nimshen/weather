using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public class WeatherData
    {
        public City City { get; set; }
        public MainTemp MainTemp { get; set; }

        public WeatherData()
        {
            City = new City();
            MainTemp = new MainTemp();
        }
    }

    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Id { get; set; }
        public Coord Coord { get; set; } 
        public City()
        {
            Coord = new Coord();
        }
    }

    public class MainTemp
    {
        public float Temp { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
        public float TempMin { get; set; }
        public float TempMax { get; set; }
    }

    public class Coord
    {
        public float Lon { get; set; }
        public float Lat { get; set; }
    }
}
