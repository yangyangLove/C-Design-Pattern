using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern_中介者模式_
{
    class ParterA : AbstractCardPartner
    {
        public override void ChaneMoneyCount(int count, AbstractMediator mediator)
        {
            mediator.AWin(count);
        }
    }
}
