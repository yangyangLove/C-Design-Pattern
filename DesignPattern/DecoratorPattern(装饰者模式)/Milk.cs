using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern_装饰者模式_
{
    public class Milk : Decorator
    {
        private Coffee _coffee;
        public Milk(Coffee coffee) :base(coffee)
        {
            _coffee = coffee;
        }
        public override decimal GetPrice()
        {
            return _coffee.GetPrice()+2;
        }

        public override string GetName()
        {
            return "milk";
        }
    }
}
