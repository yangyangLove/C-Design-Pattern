using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory_工厂模式_
{
    public class Operation
    {
        public void Calc()
        {
            Factory factory = new CookTomato();
            factory.CreateFactory().Cook();
        }
    }
}
