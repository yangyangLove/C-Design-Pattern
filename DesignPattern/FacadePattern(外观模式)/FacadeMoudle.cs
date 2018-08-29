using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FacadePattern_外观模式_
{
    public class FacadeMoudle
    {
        private MoudleA moudleA;
        private MoudleB moudleB;
        public FacadeMoudle()
        {
            moudleA = new MoudleA();
            moudleB = new MoudleB();
        }

        public void Test()
        {
            moudleA.TestA();
            moudleB.TestB();
        }
    }
}
