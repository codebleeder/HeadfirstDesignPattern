using System;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter2_Observer
{
    public class WeatherDataMonitor : IObservable<WeatherData>
    {
        List<IObserver<WeatherData>> Observers;
        private WeatherData WeatherData;

        public WeatherDataMonitor()
        {            
            Observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!Observers.Contains(observer))
                Observers.Add(observer);

            return new Unsubscriber(Observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherData>> _Observers;
            private IObserver<WeatherData> _Observer;

            public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
            {
                this._Observers = observers;
                this._Observer = observer;
            }

            public void Dispose()
            {
                if (!(_Observer == null)) _Observers.Remove(_Observer);
            }
        }

        public void NotifyObservers()
        {
            this.Observers.ForEach(o => o.OnNext(WeatherData));
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            WeatherData = new WeatherData { Temperature = temperature, Humidity = humidity, Pressure = pressure };
            NotifyObservers();
        }
    }

    
}
