using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.Operators
{
    class CircleArea : IOperable, IBiOperator
    {
        /// <summary>
        /// Tinh dien tich duong tron
        /// </summary>
        public object Calc(object input1)
        {
            if ((float)input1<0)
            {
                return null;
            }
            else
            { return (float)input1 * 3.14;
            }
            
        }

        public string Info()
        {
            return "Calc CircleArea pi * (r*r)";
        }
    }
}
