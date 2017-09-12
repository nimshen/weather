using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherService
{
    public class OpenWeatherMap : IWeatherDataService
    {
        //weatherdata object
        private static WeatherData aWeatherData;

        //singleton, private constractor and instance getter
        private static OpenWeatherMap instance;
        private OpenWeatherMap() { }
     
        public static OpenWeatherMap Instance
        {
            get
            {
                return instance = instance ?? new OpenWeatherMap();
            }
        }

        //interface method
        public WeatherData GetWeatherData(Location location)
        {
            try {
                RunAsync(location).Wait();
            } catch (WeatherDataServiceException e) { Console.WriteLine(e); }

            return aWeatherData;
        }

        static async Task RunAsync(Location city)
        {
            Location location = city;
            string key = "52601a253ef8255731af91ba057514bd";
            string units = "metric";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/weather");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("?q=" + location.Name + "&appid=" + key + "&units=" + units);
                if (response.StatusCode == HttpStatusCode.OK) {
                    string result = await response.Content.ReadAsStringAsync();
                    //@ToDo show data in weatherproj
                    //Console.WriteLine(result);
                    aWeatherData = JsonConvert.DeserializeObject<WeatherData>(result);
                    //Console.WriteLine(aWeatherData.main.temp);
                }
            }
        }
    }
}
