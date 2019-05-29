using System;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter2_Observer
{
    public class Chapter2Tests
    {
        public static void WeatherDataTest()
        {
            var weatherDataMonitor = new WeatherDataMonitor();
            var conditionsDisplay = new CurrentConditionsDisplay();
            conditionsDisplay.Subscribe(weatherDataMonitor);
            weatherDataMonitor.SetMeasurements(80, 65, 30.4f);
            weatherDataMonitor.SetMeasurements(82, 70, 29.4f);
            weatherDataMonitor.SetMeasurements(78, 90, 29.4f);
            Console.ReadLine();
        }
    }
}
