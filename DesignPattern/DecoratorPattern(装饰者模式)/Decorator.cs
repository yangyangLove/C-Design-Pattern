using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern_装饰者模式_
{
    public class Decorator : Coffee
    {
        private Coffee _coffee;

        public Decorator(Coffee coffee)
        {
            _coffee = coffee;
        }
        public override decimal GetPrice()
        {
            return _coffee.GetPrice();
        }

        public override string GetName()
        {
            return _coffee.GetName();
        }
    }
}
