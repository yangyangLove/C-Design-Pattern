using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern_建造者模式_
{
    public class Computer
    {
        public List<string> _list;

        public Computer()
        {
            _list = new List<string>();
        }

        public void Add(string str)
        {
            _list.Add(str);
        }

        public void Show()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
