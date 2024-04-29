using System;
using OpenWeatherMapAPI;

class Program
{
    static void Main(string[] args)
    {
        // Insert your OpenWeatherMap API key here
        string apiKey = "7ce910b3916abcc7c4b9c52fb9fe8f47";

        // Specify the city for which you want to get the weather
        string city = "New York";

        // Create an instance of OpenWeatherMapClient
        OpenWeatherMap client = new OpenWeatherMap(apiKey);

        // Get the weather information for the specified city
        string weatherInfo = client.GetCurrentWeather(city);

        // Display the weather information
        Console.WriteLine(weatherInfo);

    }
}




