using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern_命令模式_
{
    public abstract class RecieveCommand : ICommand
    {

        public abstract void OnExcute();
        public void Action()
        {
            OnExcute();
        }
    }
}
