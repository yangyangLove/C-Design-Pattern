namespace DesignPatternExtend.命令模式
{
    internal class Operation
    {
        public void Calc()
        {
            Receiver receiver = new RecieverA();
            ConcreteCommand command = new ConcreteCommand(receiver);
            Invoke invoke = new Invoke(command);
            invoke.Excute();
        }
    }
}
