using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod_模板方法模式_
{
    public class Operation
    {
        public void Calc()
        {
            ChineseCabbage chineseCabbage = new ChineseCabbage();
            chineseCabbage.Cook();
        }

       
    }
}
