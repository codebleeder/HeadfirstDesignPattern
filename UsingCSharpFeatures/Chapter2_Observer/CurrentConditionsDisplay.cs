using System;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter2_Observer
{
    public class CurrentConditionsDisplay : IObserver<WeatherData>, DisplayElement
    {
        private IDisposable Unsubscriber;
        private WeatherData WeatherData;

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {WeatherData.Temperature} deg F, Humidity of {WeatherData.Humidity}% ");
        }

        public void OnCompleted()
        {
            Console.WriteLine("Additional temperature and humidity data will not be transmitted.");
        }

        public void OnError(Exception error)
        {
            
        }

        public void OnNext(WeatherData value)
        {
            WeatherData = value;
            Display();
        }

        public virtual void Subscribe(IObservable<WeatherData> provider)
        {
            Unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            Unsubscriber.Dispose();
        }

    }
}
