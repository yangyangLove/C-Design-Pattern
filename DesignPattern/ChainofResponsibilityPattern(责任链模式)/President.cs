﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainofResponsibilityPattern_责任链模式_
{
    class President : Approver
    {
        public President(string name) : base(name)
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

