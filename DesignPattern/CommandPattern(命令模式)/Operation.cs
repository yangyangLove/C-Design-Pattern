using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern_命令模式_
{
    public class Operation
    {
        public void Calc()
        {
            ICommand command = CommandFactory.Make("1");
            command.Action();
        }
    }
}
