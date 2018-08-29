using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StragetyPattern_策略模式_
{
    public class CompanyTax : Tax
    {
        private double _money;
        private double _rate;
        public CompanyTax(double money,double rate)
        {
            this._money = money;
            this._rate = rate;
        }
        public override double CalculateTax()
        {
            Console.WriteLine("企业所得税");
            return _money * _rate;
        }
    }
}
