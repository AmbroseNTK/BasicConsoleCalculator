using System;

namespace BasicCalculatorCore.Operators
{ 
  class Power : IBiOperator
  { 
    public object Calc(object input1, object input2)
    {
      int total = 1;
      for(int i = 1; i <= (int)input2; i++)
      {
        total = total * (int)input1;
      }
      return total;
    }
  }
}
