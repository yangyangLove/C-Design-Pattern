namespace DesignPatternExtend.命令模式_宏命令
{
    internal interface IMacroCommand : ICommand
    {
        void AddCommand(ICommand command);
        void RemoveCommand(ICommand command);
    }
}
