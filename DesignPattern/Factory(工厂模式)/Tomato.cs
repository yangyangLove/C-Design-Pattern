using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory_工厂模式_
{
    public class Tomato : Food
    {
        public override void Cook()
        {
            Console.WriteLine("烤西红柿");
        }
    }
}
