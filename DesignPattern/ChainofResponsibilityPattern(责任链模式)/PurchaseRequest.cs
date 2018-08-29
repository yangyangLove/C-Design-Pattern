namespace DesignPattern.ChainofResponsibilityPattern_责任链模式_
{
    internal class PurchaseRequest
    {
        public string Name { get; set; }

        public double Amount { get; set; }

        public PurchaseRequest(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
