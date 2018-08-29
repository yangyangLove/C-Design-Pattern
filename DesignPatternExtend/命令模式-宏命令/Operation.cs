using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExtend.命令模式_宏命令
{
    class Operation
    {
        public void Calc()
        {
            Computer computer = new Computer();
            ICommand bios = new BIOSStartCommand(computer);
            ICommand hdd = new HDDStartCommand(computer);
            IMacroCommand macro = new ComputerMacroCommand();
            macro.AddCommand(bios);
            macro.AddCommand(hdd);
            macro.Excute();
        }
    }
}
