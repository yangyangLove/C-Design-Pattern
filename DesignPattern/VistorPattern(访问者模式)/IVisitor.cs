using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.VistorPattern_访问者模式_
{
    interface IVisitor
    {
        void Visit(ElementA element);
        void Visit(ElementB element);
    }
}
