using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WeatherService Interface
namespace WeatherService
{
    public interface IWeatherDataService
    {
        WeatherData GetWeatherData(Location location);
    }
}
