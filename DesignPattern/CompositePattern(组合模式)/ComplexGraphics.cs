using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CompositePattern_组合模式_
{
    public class ComplexGraphics : Graphics
    {
        public List<Graphics> list = new List<Graphics>();
        public ComplexGraphics(string name) : base(name)
        {

        }

        public override void Add(Graphics g)
        {
            list.Add(g);
        }

        public override void Draw()
        {
            foreach (var item in list)
            {
                Console.WriteLine("draw" + item.Name);
            }
        }

        public override void Remove(Graphics g)
        {
            list.Remove(g);
        }
    }
}
