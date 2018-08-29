using System;
using DesignPattern.Singleton_单例模式_.多线程测试;

namespace DesignPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Test operation = new Test();
            operation.Calc();
            Console.ReadKey();
        }
    }
}
