using System.Collections.Generic;

namespace DesignPattern.IteratorPattern_迭代器模式_
{
    internal class ConcreteList : IListCollection
    {
        private readonly List<int> vs;
        public ConcreteList()
        {
            vs.Add(1);
            vs.Add(2);
            vs.Add(3);
            vs.Add(4);
            vs.Add(5);
        }
        public Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length => vs.Count;

        public int GetElement(int index)
        {
            return vs[index];
        }
    }
}
