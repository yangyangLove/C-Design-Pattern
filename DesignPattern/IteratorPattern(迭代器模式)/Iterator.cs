using System;

namespace DesignPattern.IteratorPattern_迭代器模式_
{
    internal interface Iterator
    {
        bool MoveNext();
        Object GetCurrent();
        void Next();
        void Reset();
    }
}
