using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter2
{
    public interface Observer
    {
        void Update(float temp, float humidity, float pressure);
    }
}
