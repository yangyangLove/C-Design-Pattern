using System;

namespace DesignPattern.ChainofResponsibilityPattern_责任链模式_
{
    internal class Manager : Approver
    {
        public Manager(string name) : base(name)
        {

        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            Console.WriteLine(ApproverName + " apr" + request.Name);
            if (NextApprover != null)
            {
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
