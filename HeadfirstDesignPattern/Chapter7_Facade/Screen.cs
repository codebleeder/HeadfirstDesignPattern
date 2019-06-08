using System;

namespace HeadfirstDesignPattern.Chapter7_Facade
{
    public class Screen
    {
        public void Down()
        {
            Console.WriteLine("Screen down");
        }

        public void Up()
        {
            Console.WriteLine("screen up");
        }
    }
}