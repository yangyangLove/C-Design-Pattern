using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory_抽象工厂模式_
{
    public abstract class AbstractFactory
    {
        public abstract Tomato CookTomato();

        public abstract Phato CookPhato();
    }
}
