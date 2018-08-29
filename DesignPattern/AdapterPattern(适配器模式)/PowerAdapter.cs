using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern_适配器模式_
{
    public class PowerAdapter : TwoHole, IThreeHole
    {
        public void Request()
        {
            SpecificRequest();
        }
    }
}
