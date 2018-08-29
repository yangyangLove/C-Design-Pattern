using System;

namespace DesignPattern.ObserverPattern_观察者模式_
{
    internal class Subscriber : IObserver
    {
        public string Name { get; set; }
        public Subscriber(string name)
        {
            Name = name;
        }

        public void ReceiveAndPrint(TenXun tenxun)
        {
            Console.WriteLine("Notified {0} of {1}'s" + " Info is: {2}", Name, tenxun.Symbol, tenxun.Info);
        }
    }
}
