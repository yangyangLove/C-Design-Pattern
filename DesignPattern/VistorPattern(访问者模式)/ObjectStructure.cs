using System;
using System.Collections.Generic;

namespace DesignPattern.VistorPattern_访问者模式_
{
    internal class ObjectStructure
    {
        public List<Element> Elements { get; set; }

        public ObjectStructure()
        {
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                var ran = random.Next(10);
                if (ran > 5)
                {
                    Elements.Add(new ElementA());
                }
                else
                {
                    Elements.Add(new ElementB());
                }
            }
        }
    }
}
