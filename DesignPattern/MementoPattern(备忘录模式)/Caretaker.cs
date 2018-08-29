using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MementoPattern_备忘录模式_
{
    class Caretaker
    {
        public Dictionary<string, ContactMemento> dic;
        public Caretaker()
        {
            dic = new Dictionary<string, ContactMemento>();
        }
    }
}
