using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SimpleFactory_简单工厂模式_
{
    public class Tomato : Food
    {
        public override void Cook()
        {
            Console.WriteLine("烧烤西红柿");
        }
    }
}
