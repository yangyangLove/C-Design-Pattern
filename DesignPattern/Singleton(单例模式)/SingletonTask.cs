using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton_单例模式_
{
    public class SingletonTask
    {
        private static SingletonTask _instance;

        private static object _singleLock;
        public static SingletonTask Instance()
        {
            if (_instance==null)//适用于多线程的时候
            {
                lock (_singleLock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonTask();
                    }
                }
            }
            return _instance;
        }
    }
}
