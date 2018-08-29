namespace DesignPattern.MediatorPattern_中介者模式_
{
    internal abstract class AbstractMediator
    {
        protected readonly AbstractCardPartner A;
        protected readonly AbstractCardPartner B;

        public AbstractMediator(AbstractCardPartner a, AbstractCardPartner b)
        {
            A = a;
            B = b;
        }

        public abstract void AWin(int count);

        public abstract void BWin(int count);
    }
}
