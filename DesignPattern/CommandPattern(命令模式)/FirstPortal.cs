using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern_命令模式_
{
    public class FirstPortal : RecieveCommand
    {
        public override void OnExcute()
        {
            Console.WriteLine("aa");
        }
    }
}
