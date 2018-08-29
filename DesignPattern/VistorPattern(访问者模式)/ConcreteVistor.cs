using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.VistorPattern_访问者模式_
{
    class ConcreteVistor : IVisitor
    {
        public void Visit(ElementA element)
        {
            element.Print();
        }

        public void Visit(ElementB element)
        {
            element.Print();
        }
    }
}
