using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern_迭代器模式_
{
    interface IListCollection
    {
        Iterator GetIterator();
    }
}
