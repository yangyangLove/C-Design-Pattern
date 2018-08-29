using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExtend.命令模式
{
    class RecieverA : Receiver
    {
        public override void Run()
        {
            Console.WriteLine("studenta run 1000");
        }
    }
}
