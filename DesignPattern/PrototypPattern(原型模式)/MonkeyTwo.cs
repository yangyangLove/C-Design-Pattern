using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypPattern_原型模式_
{
    public class MonkeyTwo : Monkey
    {
        public MonkeyTwo(string id) : base(id)
        {

        }
        public override Monkey Clone()
        {
            return (Monkey)this.MemberwiseClone();
        }
    }
}
