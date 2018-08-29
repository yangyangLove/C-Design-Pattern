using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern_中介者模式_
{
    class Operation
    {
        public void Calc()
        {
            AbstractCardPartner A = new ParterA();
            AbstractCardPartner B = new ParterB();
            A.MoneyCount = 20;
            B.MoneyCount = 20;

            AbstractMediator mediator = new MediatorPater(A, B);
            A.ChaneMoneyCount(5, mediator);

            B.ChaneMoneyCount(10, mediator);
        }
    }
}
