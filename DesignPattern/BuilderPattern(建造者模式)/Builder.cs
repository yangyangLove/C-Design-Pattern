using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern_建造者模式_
{
    public abstract class Builder
    {
        public abstract void BuildPartCPU();

        public abstract void BuildPartMainBoard();

        public abstract Computer GetComputer();
    }
}
