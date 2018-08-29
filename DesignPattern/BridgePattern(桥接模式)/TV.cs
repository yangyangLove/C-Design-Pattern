using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BridgePattern_桥接模式_
{
    public abstract class TV
    {
        public abstract void On();
        public abstract void Off();
        public abstract void tuneChannel();
    }
}
