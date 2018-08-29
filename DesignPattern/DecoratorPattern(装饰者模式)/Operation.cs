using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern_装饰者模式_
{
    public class Operation
    {
        public void Calc()
        {
            SimpleCoffee coffee = new SimpleCoffee();
            Decorator milk = new Milk(coffee);
            //Decorator apple = new Apple(coffee);
            Console.WriteLine(milk.GetPrice().ToString());

            Milk milk1 = new Milk(coffee);
            Apple apple1 = new Apple(milk1);
            Console.WriteLine(apple1.GetPrice().ToString());
        }
    }
}
