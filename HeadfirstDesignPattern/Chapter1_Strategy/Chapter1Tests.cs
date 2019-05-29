using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter1
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
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
            Console.ReadLine();
        }
    }
}
