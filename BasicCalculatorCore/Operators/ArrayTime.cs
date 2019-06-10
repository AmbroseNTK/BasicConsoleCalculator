using System;
using System.Collections.Generic;
using System.Text;
using BasicCalculatorCore.Operators;

namespace BasicCalculatorCore.Operators
{
    public class ArrayTime : IMonoOperator, IOperable
    {
        public double Time;
        public object Calc(object input)
        {
            double[] arr = input as double[];
            if (arr.Length == 0)
            {
                return 0;
            }
            Time = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                Time *= arr[i];
            }
            return Time;
        }
        public string Info()
        {
            throw new NotImplementedException();
        }
    }
}
