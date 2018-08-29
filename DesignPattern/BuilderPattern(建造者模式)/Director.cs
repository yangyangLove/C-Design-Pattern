using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern_建造者模式_
{
    public class Director
    {
        public void Contruct(Builder builder)
        {
            builder.BuildPartCPU();
            builder.BuildPartMainBoard();
        }
    }
}
