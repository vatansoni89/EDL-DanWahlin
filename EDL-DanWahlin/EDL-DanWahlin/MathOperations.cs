﻿using System;
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
    }
}
