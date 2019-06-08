using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter7_Adapter
{
    public class TurkeyAdapter : Duck
    {
        Turkey Turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            Turkey = turkey;
        }
        public void Fly()
        {
            // Turkeys fly in short spurts
            for(var i=0; i<5; i++)
            {
                Turkey.Fly();
            }
            
        }

        public void Quack()
        {
            Turkey.Gobble();
        }
    }
}
