using System;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter2_Observer
{
    public class Chapter2Tests
    {
        public static void WeatherDataTest()
        {
            var weatherDataMonitor = new WeatherDataMonitor(); // Observable
            var display1 = new CurrentConditionsDisplay("Display 1"); // Observer
            display1.Subscribe(weatherDataMonitor);

            var display2 = new CurrentConditionsDisplay("Display 2");
            display2.Subscribe(weatherDataMonitor);

            weatherDataMonitor.SetMeasurements(80, 65, 30.4f);
            weatherDataMonitor.SetMeasurements(82, 70, 29.4f);
            weatherDataMonitor.SetMeasurements(78, 90, 29.4f);

            display2.Unsubscribe();
            weatherDataMonitor.SetMeasurements(80, 65, 30.4f);
            weatherDataMonitor.SetMeasurements(82, 70, 29.4f);
            weatherDataMonitor.SetMeasurements(78, 90, 29.4f);
        }
    }
}
