using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern_命令模式_
{
    public class CommandFactory
    {

        public static ICommand Make(string type)
        {
            ICommand command = null;
            switch (type)
            {
                case "1":
                    command = new FirstPortal();
                    break;
                default:
                    break;
            }
            return command;
        }
    }
}
