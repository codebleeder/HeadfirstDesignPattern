using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter5_Singleton
{
    // without lock - not lazy 
    public class SingletonThreadSafe2
    {
        private static readonly SingletonThreadSafe2 Instance = new SingletonThreadSafe2();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonThreadSafe2()
        {
        }

        private SingletonThreadSafe2() { }
        public static SingletonThreadSafe2 GetInstance()
        {
            return Instance;
        }
    }
}
