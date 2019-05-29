using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter2
{
    class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float Temperature;
        private float Humidity;
        private Subject WeatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {Temperature} deg F, Humidity of {Humidity}% ");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Display();
        }
    }
}
