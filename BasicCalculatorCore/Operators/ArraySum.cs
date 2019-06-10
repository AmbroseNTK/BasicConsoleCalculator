using System;
using BasicCalculatorCore.Operators;

public class ArraySum : IMonoOperator, IOperable
{
    public double Sum;
    public object Calc(object input)
    {
        double[] arr = input as double[];
        if (arr.Length == 0)
        {
            return 0;
        }
        Sum = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            Sum += arr[i];
        }
        return input;
    }

    public string Info()
    {
        throw new NotImplementedException();
    }
}
