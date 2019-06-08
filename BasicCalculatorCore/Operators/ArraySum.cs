using System;
using BasicCalculatorCore.Operators;

public class ArraySum : IMonoOperator, IOperable
{
    public object[] input;
    public object Length { get; }
    public object Sum;
    public object Calc(object input)
    {
        Sum = input[0];
        for (object i = 1; i < input.Length; i++)
        {
            Sum += input[i];
        }
        return input;
    }
}
