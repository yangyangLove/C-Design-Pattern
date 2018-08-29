using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern_观察者模式_
{
    interface IObserver
    {
        void ReceiveAndPrint(TenXun tenXun);
    }
}
