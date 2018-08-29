using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern_装饰者模式_
{
    public abstract class Coffee
    {
        public abstract decimal GetPrice();

        public abstract string GetName();
    }
}
