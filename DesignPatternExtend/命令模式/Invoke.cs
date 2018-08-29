using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExtend.命令模式
{
    class Invoke
    {
        public ICommand _command;
        public Invoke(ICommand command)
        {
            _command = command;
        }
        public void Excute()
        {
            _command.Action();
        }
    }
}
