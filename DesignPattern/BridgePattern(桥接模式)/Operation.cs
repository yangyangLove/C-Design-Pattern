using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BridgePattern_桥接模式_
{
    public class Operation
    {
        public void Calc()
        {
            RemoteControl remoteControl = new ConcreteRemote();
            remoteControl.TV = new Samsung();
            remoteControl.On();
            remoteControl.SetChannel();
            remoteControl.Off();
        }
    }
}
