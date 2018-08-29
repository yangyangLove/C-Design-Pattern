using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory_抽象工厂模式_
{
    public class LiaoNingFactory : AbstractFactory
    {
        public override Phato CookPhato()
        {
            return new LiaoNingPotato();
        }

        public override Tomato CookTomato()
        {
            return new LiaoNingTomato();
        }
    }
}
