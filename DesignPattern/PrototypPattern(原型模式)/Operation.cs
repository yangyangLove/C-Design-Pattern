using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypPattern_原型模式_
{
    public class Operation
    {
        public void Calc()
        {
            Monkey monkey = new MonkeyTwo("houzi") as MonkeyTwo;
            Console.WriteLine(monkey.Clone().Id);
        }
    }
}
