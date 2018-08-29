using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BridgePattern_桥接模式_
{
    public class RemoteControl
    {

        public TV TV { get; set; }

        public virtual void On()
        {
            TV.On();
        }

        public virtual void Off()
        {
            TV.Off();
        }

        public virtual void SetChannel()
        {
            TV.tuneChannel();
        }
    }
}
