using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FlyweightPattern_享元模式_
{
    public class Operation
    {
        public void Calc()
        {
            FlyweightFactory flyweightFactory = new FlyweightFactory();
            var a = flyweightFactory.GetFlyweight(1);
            if (a != null)
            {
                a.Operation(10);
            }
            var d = flyweightFactory.GetFlyweight(5);
            if (d != null)
            {
                d.Operation(20);
            }
            else
            {
                flyweightFactory.dic.Add(4, new ConcreteFlyweight(4));
            }
        }

    }
}
