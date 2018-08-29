using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FlyweightPattern_享元模式_
{
    public class ConcreteFlyweight : Flyweight
    {
        private int intrinsicstate;
        public ConcreteFlyweight(int innerState)
        {
            this.intrinsicstate = innerState;
        }

        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine(this.GetType().Name + extrinsicstate + ":key is" + extrinsicstate);
        }
    }
}
