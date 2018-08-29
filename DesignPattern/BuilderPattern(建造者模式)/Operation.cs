using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern_建造者模式_
{
    public class Operation
    {
        public void Calc()
        {
            Director director = new Director();
            Builder builder = new ConcreteBuilder1();
            director.Contruct(builder);
            Computer computer = builder.GetComputer();
            computer.Show();
        }

    }
}
