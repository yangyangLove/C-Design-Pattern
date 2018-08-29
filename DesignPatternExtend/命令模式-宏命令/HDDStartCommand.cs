using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExtend.命令模式_宏命令
{
    class HDDStartCommand : ICommand
    {
        public Computer _computer;
        public HDDStartCommand(Computer computer)
        {
            _computer = computer;
        }
        public void Excute()
        {
            _computer.StartHDD();
        }
    }
}

