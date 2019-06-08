using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.Operators
{
    /// <summary>
    /// Tính diện tích hình tròn
    /// </summary>
    class Acreage : IOperable, IMonoOperator
    {       
        public object Calc(object input)
        {
            return (double)input * (Math.PI) * Math.Pow((double)input, 2);
        }

        public string Info()
        {
            return "Acreage circle";
        }
    }
}
