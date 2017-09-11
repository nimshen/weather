using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public class Location
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Location(string cityName)
        {
            Name = cityName;
        }

        public Location(string cityName, int id)
        {
            Name = cityName;
            Id = id;
        }
    }
}
