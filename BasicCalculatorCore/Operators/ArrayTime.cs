using System;
using System.Collections.Generic;
using System.Text;
using BasicCalculatorCore.Operators;

namespace BasicCalculatorCore.Operators
{
    public class ArrayTime : IMonoOperator, IOperable
    {
        public object[] input;
        public object Length { get; }
        public object Time;
        public object Calc(object input)
        {
            Time = input[0];
            for (object i = 1; i < input.Length; i++)
            {
                Sum *= input[i];
            }
            return input;
        }
    }
}
