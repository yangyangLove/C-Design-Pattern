using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern_建造者模式_
{
    public class ConcreteBuilder1 : Builder
    {
        Computer _computer;
        public override void BuildPartCPU()
        {
            _computer.Add("shenzhou'cpu");
        }

        public override void BuildPartMainBoard()
        {
            _computer.Add("shenzhou'board");
        }

        public override Computer GetComputer()
        {
            return _computer;
        }
    }
}
