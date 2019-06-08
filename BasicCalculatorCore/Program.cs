using System;

using BasicCalculatorCore.Operators;

namespace BasicCalculatorCore
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperable op = new Add();
            int result = (int)(op as IBiOperator).Calc(2, 3);
            Console.WriteLine("2 + 3 = " + result);
           
        }
    }
}
