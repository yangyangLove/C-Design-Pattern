using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod_模板方法模式_
{
    public abstract class Vegetabel
    {
        public void Cook()
        {
            PourOil();
            HeatOil();
            PourVegetable();
            Stir_fry();
        }
        // 第一步倒油
        public void PourOil()
        {
            Console.WriteLine("倒油");
        }
        // 把油烧热
        public void HeatOil()
        {
            Console.WriteLine("把油烧热");
        }
        // 油热了之后倒蔬菜下去，具体哪种蔬菜由子类决定
        public abstract void PourVegetable();

        // 开发翻炒蔬菜
        public void Stir_fry()
        {
            Console.WriteLine("翻炒");
        }
    }
}
