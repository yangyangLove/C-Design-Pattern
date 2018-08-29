using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FacadePattern_外观模式_
{
    public class Operation
    {
        public void Calc()
        {
            FacadeMoudle facade = new FacadeMoudle();
            facade.Test();
        }
    }
}
