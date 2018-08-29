using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory_抽象工厂模式_
{
    public class Operation
    {
        public void Calc()
        {
            AbstractFactory factory = new LiaoNingFactory();
            Phato potato= factory.CookPhato();
            potato.GetPotato();
        }
    }
}
