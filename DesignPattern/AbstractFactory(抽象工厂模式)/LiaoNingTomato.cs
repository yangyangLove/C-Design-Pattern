using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory_抽象工厂模式_
{
    public class LiaoNingTomato : Tomato
    {
        public override void GetTomato()
        {
            Console.WriteLine("LiaoNing cook tomato");
        }
    }
}
