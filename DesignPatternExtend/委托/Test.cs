using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExtend.委托
{
    class Test
    {
        public void Calc()
        {
            Computer computer = new Computer();
            int sum = 0;
            Func<int> func = null;
            func += computer.Get;
            func += computer.Post;
            func += computer.Delete;
            for (int i = func.GetInvocationList().Length-1; i >= 0; i--)
            {
                Delegate @delegate = func.GetInvocationList()[i];
                sum += (int)@delegate.DynamicInvoke();
            }
        }
    }
}
