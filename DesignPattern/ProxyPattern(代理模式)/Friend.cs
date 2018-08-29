using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyPattern_代理模式_
{
    public class Friend : Person
    {
        private RealBuyPerson buyPerson;

        public override void BuyProduct()
        {
            if (buyPerson==null)
            {
                buyPerson = new RealBuyPerson();
            }
            PreBuyProduct();
            buyPerson.BuyProduct();
            EndBuyProduct();
        }

        public void PreBuyProduct()
        {
            Console.WriteLine("this is an order list");
        }

        public void EndBuyProduct()
        {
            Console.WriteLine("it's end");
        }
    }
}
