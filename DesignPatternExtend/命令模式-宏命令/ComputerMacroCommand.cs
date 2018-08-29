using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExtend.命令模式_宏命令
{
    class ComputerMacroCommand : IMacroCommand
    {
        public List<ICommand> commandList;
        public ComputerMacroCommand()
        {
            commandList = new List<ICommand>();
        }
        public void AddCommand(ICommand command)
        {
            commandList.Add(command);
        }
        public void RemoveCommand(ICommand command)
        {
            commandList.Remove(command);
        }
        public void Excute()
        {
            foreach (var item in commandList)
            {
                item.Excute();
            }
        }
    }
}
