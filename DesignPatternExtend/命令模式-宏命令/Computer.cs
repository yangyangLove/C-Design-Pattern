using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExtend.命令模式_宏命令
{
    class Computer
    {
        public void StartBIOS()
        {
            Console.WriteLine("start bios");
        }

        public void StartHDD()
        {
            Console.WriteLine("start hdd");
        }
    }
}
