using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter2
{
    public interface Subject
    {
        void RegisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObservers();
    }
}
