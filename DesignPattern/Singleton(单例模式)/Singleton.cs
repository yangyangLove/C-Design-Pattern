using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton_单例模式_
{
    public class Singleton
    {
        private static Singleton _instance;
        public Singleton()
        {

        }

        public static Singleton Instance()
        {
            if (_instance==null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
