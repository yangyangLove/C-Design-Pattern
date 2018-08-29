using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypPattern_原型模式_
{
    public abstract class Monkey 
    {
        public string Id { get; set; }
        public Monkey(string id)
        {
            Id = id;
        }

        public abstract Monkey Clone();
    }
}
