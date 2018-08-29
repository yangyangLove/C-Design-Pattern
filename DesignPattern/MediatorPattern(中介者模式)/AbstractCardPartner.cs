namespace DesignPattern.MediatorPattern_中介者模式_
{
    internal abstract class AbstractCardPartner
    {
        public int MoneyCount { get; set; }

        public AbstractCardPartner()
        {
            MoneyCount = 0;
        }

        public abstract void ChaneMoneyCount(int count, AbstractMediator mediator);
    }
}
