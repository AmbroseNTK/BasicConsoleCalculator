using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.Operators
{
    /// <summary>
    /// Tính chu vi hình tròn
    /// </summary>
    class Perimeter : IOperable, IMonoOperator
    {
        public object Calc(object input)
        {
            return (double)input * 2 * (Math.PI);
        }

        public string Info()
        {
            return "Calc perimeter circle";
        }
    }
}
