using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StragetyPattern_策略模式_
{
    public class PersonalTax : Tax
    {
        private double _money;
        public PersonalTax(double momey)
        {
            this._money = momey;
        }
        public override double CalculateTax()
        {
            Console.WriteLine("个税计算");
            return _money * 0.3;
        }
    }
}
