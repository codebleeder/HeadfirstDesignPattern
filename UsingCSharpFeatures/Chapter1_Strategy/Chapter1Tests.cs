using System;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter1_Strategy
{
    public class Chapter1Tests
    {
        public static void TestMallardDuck()
        {
            var mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();
            Console.ReadLine();
        }

        public static void TestModelDuck()
        {
            var model = new ModelDuck();
            model.performFly();
            model.SetFlyBehavior(FlyBehavior.FlyRocketPowered);
            model.performFly();
            Console.ReadLine();
        }
    }
}
