using System;
using System.Collections.Generic;
using System.Text;

namespace EDL_DanWahlin
{
    class MathOperations
    {
        public void Calc(int x, int y, DelMathOperations op)
        {
          Console.WriteLine(op(x, y));  
        }

        public void ProcessAction(int x, int y, Action<int, int> ac)
        {
            ac(x, y);
        }
        public void ProcessFunc(int x, int y, Func<int, int, int> ac)
        {
            Console.WriteLine($"Func processed and, sum is {ac(x,y)}");
        }
    }
}
