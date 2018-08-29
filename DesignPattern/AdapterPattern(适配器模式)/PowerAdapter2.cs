using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern_适配器模式_
{
    public class PowerAdapter2 : ThreeHole
    {
        public TwoHole twoholeAdaptee = new TwoHole();
        public override void Request()
        {
            twoholeAdaptee.SpecificRequest();
        }
    }
}
