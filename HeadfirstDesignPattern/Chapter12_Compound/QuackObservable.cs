using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public class QuackObservable : IObservable<IQuackable>
    {
        List<IObserver<IQuackable>> Observers;
        IQuackable Duck;
        public QuackObservable(IQuackable duck)
        {
            Observers = new List<IObserver<IQuackable>>();
            Duck = duck;
        }
        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            Observers.Add(observer);
            return new Unsubscriber(Observers, observer);
        }
        public void NotifyObservers()
        {
            this.Observers.ForEach(o => o.OnNext(Duck));
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<IQuackable>> _Observers;
            private IObserver<IQuackable> _Observer;

            public Unsubscriber(List<IObserver<IQuackable>> observers, IObserver<IQuackable> observer)
            {
                this._Observers = observers;
                this._Observer = observer;
            }

            public void Dispose()
            {
                if (!(_Observer == null)) _Observers.Remove(_Observer);
            }
        }
    }
}
