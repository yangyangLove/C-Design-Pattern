using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SimpleFactory_简单工厂模式_
{
    public class FoodFactory
    {
        public static Food CreateFactory(string type)
        {
            Food food = null;
            switch (type)
            {
                case "1":
                    food = new Tomato();
                    break;
                case "2":
                    food = new Phtao();
                    break;
                default:
                    break;
            }
            return food;
        }
    }
}
