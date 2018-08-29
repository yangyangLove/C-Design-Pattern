namespace DesignPattern.VistorPattern_访问者模式_
{
    internal class Operation
    {
        public void Calc()
        {
            ObjectStructure objectStructure = new ObjectStructure();
            foreach (var item in objectStructure.Elements)
            {
                item.Accept(new ConcreteVistor());
            }

        }
    }
}
