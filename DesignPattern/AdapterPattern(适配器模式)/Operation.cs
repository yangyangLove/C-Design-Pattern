using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern_适配器模式_
{
    public class Operation
    {
        public void Calc()
        {
            IThreeHole threehole = new PowerAdapter();
            threehole.Request();

            ThreeHole threeHole = new PowerAdapter2();
            threeHole.Request();
        }
    }
}
