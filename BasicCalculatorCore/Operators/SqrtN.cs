using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.Operators
{
    class SqrtN : IOperable, IBiOperator, IMonoOperator
    {
        public object Calc(object input1, object input2)
        {
            return Math.Pow((double)input1, (double)input2);
        }

        public object Calc(object input)
        {
            return Math.Sqrt((double)input);
        }

        public string Info()
        {
            return "Sqrt of x";
        }
    }
}
