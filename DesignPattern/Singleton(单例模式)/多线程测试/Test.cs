using System;
using System.Threading;

namespace DesignPattern.Singleton_单例模式_.多线程测试
{
    public class Test
    {
        public void Calc()
        {
            Thread vThread = new Thread(ThreadFun);
            vThread.Start(); //开始执行线程
        }

        public void ThreadFun() // 来自委托：ThreadStart 
        {
            Thread vThread = new Thread(ThreadFun1);
            vThread.Start();
            Random random = new Random(); 
            for (int i =11; i < 13; i++)
            {
                int asid = 100000;
                for (int j = 1; j < 3; j++)
                {
                    for (int h = 1; h < 3; h++)
                    {
                        Console.WriteLine(" quzhi ");
                        var c=Test1.Instance().LoadString(asid, h);
                        Console.WriteLine(h+" out " +string.Join(",",c));
                    }

                    Thread.Sleep(500);
                }
            }
            Console.WriteLine("THREAD END");
        }
        public void ThreadFun1() // 来自委托：ThreadStart 
        {
            Random random = new Random();
            for (int i = 12; i < 15; i++)
            {
                int asid = 100000;
                for (int j = 1; j < 4; j++)
                {
                    Test1.Instance().LoadString1(asid, j);
                }
                Thread.Sleep(400);
                Test1.Instance().RemoveString(asid);
            }
            Console.WriteLine("THREAD END");
        }
    }
}
