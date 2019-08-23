using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public class GooseAdapter : IQuackable
    {
        Goose Goose;
        public GooseAdapter(Goose goose)
        {
            Goose = goose;
        }
        public void Quack()
        {
            Goose.Honk();
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            throw new NotImplementedException();
        }
    }
}
