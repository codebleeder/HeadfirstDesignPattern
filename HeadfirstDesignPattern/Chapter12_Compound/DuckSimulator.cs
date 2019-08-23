using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public class DuckSimulator
    {

        public void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            
            var gooseDuck = new GooseAdapter(new Goose());
            Console.WriteLine("Duck simulator");

            var flockOfDucks = new Flock();
            flockOfDucks.Add(gooseDuck);
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);

            var flockOfMallards = new Flock();
            IQuackable mallardDuck1 = duckFactory.CreateMallardDuck();
            IQuackable mallardDuck2 = duckFactory.CreateMallardDuck();
            IQuackable mallardDuck3 = duckFactory.CreateMallardDuck();
            IQuackable mallardDuck4 = duckFactory.CreateMallardDuck();
            flockOfMallards.Add(mallardDuck1);
            flockOfMallards.Add(mallardDuck2);
            flockOfMallards.Add(mallardDuck3);
            flockOfMallards.Add(mallardDuck4);
            flockOfDucks.Add(flockOfMallards);

            var quackologist = new Quackologist();
            flockOfMallards.Subscribe(quackologist);

            Console.WriteLine("Duck simulator: whole flock simulation");
            Simulate(flockOfDucks);

            Console.WriteLine("Duck simulator: Mallard flock simulation");
            Simulate(flockOfMallards);

            Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}