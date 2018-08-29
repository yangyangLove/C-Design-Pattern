using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BridgePattern_桥接模式_
{
    public class ConcreteRemote : RemoteControl
    {
        public override void SetChannel()
        {
            Console.WriteLine("new bll");
            base.SetChannel();
        }
    }
}
