using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter5_Singleton
{
    public class Singleton
    {
        private static Singleton uniqueInstance;
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
    }
}
