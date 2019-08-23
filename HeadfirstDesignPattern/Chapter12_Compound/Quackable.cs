using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public interface IQuackable: IObservable<IQuackable>
    {
        void Quack();
    }
}
