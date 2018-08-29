namespace DesignPattern.ChainofResponsibilityPattern_责任链模式_
{
    internal class Operation
    {
        public void Calc()
        {
            PurchaseRequest request = new PurchaseRequest("iphone", 8000);
            Approver manager = new Manager("tom");
            Approver vre = new VicePresident("lyn");
            Approver pre = new President("marin");
            manager.NextApprover = vre;
            vre.NextApprover = pre;
            manager.ProcessRequest(request);
        }
    }
}
