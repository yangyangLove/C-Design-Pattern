using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StragetyPattern_策略模式_
{
    public class Calc
    {
        private Tax _tax;

        public Calc(TaxType type,double money,double rate)
        {
            switch (type)
            {
                case TaxType.CompanyTax:
                    _tax = new CompanyTax(money, rate);
                    break;
                case TaxType.PersonTax:
                    _tax = new PersonalTax(money);
                    break;
                default:
                    break;
            }
        }

        public double CalcTax()
        {
            return _tax.CalculateTax();
        }
    }
}
