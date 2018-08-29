namespace DesignPatternExtend.命令模式
{
    internal class ConcreteCommand : ICommand
    {
        public Receiver _receiver;
        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void Action()
        {
            _receiver.Run();
        }
    }
}
