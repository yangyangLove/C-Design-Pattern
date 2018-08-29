using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyPattern_代理模式_
{
    public class RealBuyPerson : Person
    {
        public override void BuyProduct()
        {
            Console.WriteLine("best friend buy a computer");
        }
    }
}
