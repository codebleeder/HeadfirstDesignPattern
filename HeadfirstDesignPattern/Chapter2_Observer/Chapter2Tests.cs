using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter2
{
    public class Chapter2Tests
    {
        public static void WeatherDataTest()
        {
            var weatherData = new WeatherData();
            var conditionsDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.4f);
            weatherData.SetMeasurements(78, 90, 29.4f);
            Console.ReadLine();
        }
    }
}
