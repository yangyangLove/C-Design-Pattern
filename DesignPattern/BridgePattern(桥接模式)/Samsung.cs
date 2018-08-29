using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BridgePattern_桥接模式_
{
    public class Samsung : TV
    {
        public override void Off()
        {
            Console.WriteLine("close samsung tv");
        }

        public override void On()
        {
            Console.WriteLine("open samsung tv");
        }

        public override void tuneChannel()
        {
            Console.WriteLine("turn samsung channel");
        }
    }
}
