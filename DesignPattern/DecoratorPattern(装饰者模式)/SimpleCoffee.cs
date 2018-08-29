using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern_装饰者模式_
{
    public class SimpleCoffee : Coffee
    {
        public override string GetName()
        {
            return "simple";
        }

        public override decimal GetPrice()
        {
            return 2;
        }
    }
}
