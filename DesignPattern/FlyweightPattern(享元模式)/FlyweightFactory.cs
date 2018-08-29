using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FlyweightPattern_享元模式_
{
    public class FlyweightFactory
    {
        public readonly Dictionary<int, Flyweight> dic = new Dictionary<int, Flyweight>();

        public FlyweightFactory()
        {
            dic.Add(1, new ConcreteFlyweight(1));
            dic.Add(2, new ConcreteFlyweight(2));
        }

        public Flyweight GetFlyweight(int key)
        {
            return dic[key];
        }
    }
}
