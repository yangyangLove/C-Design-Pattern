using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern_中介者模式_
{
    class ParterB : AbstractCardPartner
    {
        public override void ChaneMoneyCount(int count, AbstractMediator mediator)
        {
            mediator.BWin(count);
        }
    }
}
