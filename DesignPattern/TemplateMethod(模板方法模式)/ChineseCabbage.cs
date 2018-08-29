using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod_模板方法模式_
{
    public class ChineseCabbage : Vegetabel
    {
        public override void PourVegetable()
        {
            Console.WriteLine("add chinesecabbage");
        }
    }
}
