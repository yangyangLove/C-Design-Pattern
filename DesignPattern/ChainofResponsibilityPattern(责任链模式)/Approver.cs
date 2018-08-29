using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainofResponsibilityPattern_责任链模式_
{
    abstract class Approver
    {
        public Approver NextApprover;
        public string ApproverName { get; set; }
        public Approver(string name)
        {
            ApproverName = name;
        }

      public  abstract void ProcessRequest(PurchaseRequest request);
    }
}
