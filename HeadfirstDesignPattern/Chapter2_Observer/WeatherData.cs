using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter2
{
    public class WeatherData : Subject
    {
        private List<Observer> Observers;
        private float Temperature;
        private float Humidity;
        private float Pressure; 

        public WeatherData()
        {
            Observers = new List<Observer>();
        }

        public void NotifyObservers()
        {
            this.Observers.ForEach(o=>o.Update(Temperature, Humidity, Pressure));
        }

        public void RegisterObserver(Observer o)
        {
            this.Observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            this.Observers.Remove(o);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}
