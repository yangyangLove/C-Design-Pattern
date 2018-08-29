using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern_观察者模式_
{
    class Operation
    {
        public void Calc()
        {
            TenXun tenXun = new TenXunGame("TenXun Game", "Have a new game published ....");
            tenXun.AddObserver(new Subscriber("Learning Hard"));
            tenXun.AddObserver(new Subscriber("Tom"));
            tenXun.Update();
        }
    }
}
