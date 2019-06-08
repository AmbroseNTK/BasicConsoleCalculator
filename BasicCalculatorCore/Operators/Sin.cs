using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.Operators
{
    class Sin : IOperable, IMonoOperator
    {
        public object Calc(object input)
        {
            return Math.Sin((double)input);
        }

        public string Info()
        {
            return "sin of x";
        }
    }
}
