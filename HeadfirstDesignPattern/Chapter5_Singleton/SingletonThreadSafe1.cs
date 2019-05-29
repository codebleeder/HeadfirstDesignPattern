using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter5_Singleton
{
    class SingletonThreadSafe1
    {
        private static SingletonThreadSafe1 Instance;
        private static readonly object padlock = new object();

        private SingletonThreadSafe1() { }
        
        public static SingletonThreadSafe1 GetInstance()
        {            
            lock(padlock)
            {
                if (Instance == null)
                {
                    Instance = new SingletonThreadSafe1();
                }
                return Instance;
            }            
        }
    }
}
