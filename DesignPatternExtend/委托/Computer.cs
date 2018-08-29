using System;

namespace DesignPatternExtend.委托
{
    internal class Computer
    {
        public int Get()
        {
            int a = 1;
            Func<int, int> func = (v) => v + 2;
            return a + func(1);
        }

        public int Post()
        {
            return 3;
        }

        public int Delete()
        {
            return 4;
        }
    }
}
