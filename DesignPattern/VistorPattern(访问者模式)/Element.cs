using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.VistorPattern_访问者模式_
{
   abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
        public abstract void Print();
    }
}
