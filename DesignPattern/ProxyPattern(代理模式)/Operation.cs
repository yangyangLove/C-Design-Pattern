using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyPattern_代理模式_
{
    public class Operation
    {
        public void Calc()
        {
            Person proxy = new Friend();
            proxy.BuyProduct();
        }
    }
}
