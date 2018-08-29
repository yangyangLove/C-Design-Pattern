using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CompositePattern_组合模式_
{
    public abstract class Graphics
    {
        public string Name { get; set; }

        public Graphics(string name)
        {
            Name = name;
        }

        public abstract void Draw();

        public abstract void Add(Graphics g);

        public abstract void Remove(Graphics g);
    }
}
