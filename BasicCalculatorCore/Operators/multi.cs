using BasicCalculatorCore.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.operators
{
    class Multi : IOperable, IBiOperator
    {
        public object Calc(object input1, object input2)
        {
            return (int)input1 * (int)input2;
        }

        public string Info()
        {
            return "Calc a * b";
        }
    }
}
