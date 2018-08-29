using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory_工厂模式_
{
    public class CookTomato : Factory
    {
        public override Food CreateFactory()
        {
            return new Tomato();
        }
    }
}
