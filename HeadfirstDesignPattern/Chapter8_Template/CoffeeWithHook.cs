using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter8_Template
{
    public class CoffeeWithHook : CaffeinBeverageWithHook
    {
        public override void AddCondiments()
        {
            Console.WriteLine("coffee: add sugar and milk");
        }

        public override void Brew()
        {
            Console.WriteLine("coffee: brew coffee grinds");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();
            if (answer.ToLower().StartsWith('y'))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private string GetUserInput()
        {
            Console.WriteLine("would you like milk and sugar with your coffee (y/n) ? ");
            var answer = Console.ReadLine();
            if (answer == null) return "no";
            return answer;
        }
    }
}
