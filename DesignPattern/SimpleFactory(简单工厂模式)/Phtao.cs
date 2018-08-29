using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SimpleFactory_简单工厂模式_
{
    public class Phtao : Food
    {
        public override void Cook()
        {
            Console.WriteLine("烤土豆");
        }
    }
}
