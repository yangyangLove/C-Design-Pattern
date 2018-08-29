using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern_迭代器模式_
{
    class Operation
    {
        public void Calc()
        {
            IListCollection list = new ConcreteList();
            Iterator iterator = list.GetIterator();
            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                iterator.Next();
            }
        }
    }
}
