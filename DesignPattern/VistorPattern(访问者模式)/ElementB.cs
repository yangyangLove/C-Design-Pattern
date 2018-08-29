using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.VistorPattern_访问者模式_
{
    class ElementB : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("print b");
        }
    }
}
