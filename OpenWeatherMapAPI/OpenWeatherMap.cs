using System;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMapAPI
{
	public class OpenWeatherMap
	{
        private HttpClient _httpClient;
        private string _apiKey;

		public OpenWeatherMap(string apiKey)
		{
            _httpClient = new HttpClient();
			_apiKey = apiKey;

		}
        public string GetWeather(string city)
        {
         HttpResponseMessage response = _httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=imperial").Result;

         string response1 = response.Content.ReadAsStringAsync().Result;
         return response1;
           
        }

        public string GetCurrentWeather(string city)
        {
            string response1 = GetWeather(city);

            JObject json = JObject.Parse(response1);

            string cityName = (string)json["name"];

            double temperature = (double)json["main"]["temp"];

            string weatherDescription = (string)json["weather"][0]["description"];

            return $"Weather in {cityName}:\nTemperature: {temperature}°F\nDescription: {weatherDescription}";
        }

    }
}

