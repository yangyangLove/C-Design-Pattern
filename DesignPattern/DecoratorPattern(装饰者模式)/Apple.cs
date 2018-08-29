using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern_装饰者模式_
{
    public class Apple : Decorator
    {
        private Coffee _coffee;
        public Apple(Coffee coffee) : base(coffee)
        {
            _coffee = coffee;
        }
        public override decimal GetPrice()
        {
            return _coffee.GetPrice() + 10;
        }

        public override string GetName()
        {
            return "apple";
        }
    }
}
