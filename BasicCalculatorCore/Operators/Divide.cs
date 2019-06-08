using System;



namespace BasicCalculatorCore.Operators {
  class Divide : IBiOperator 
  {
    public object Calc(object input1, object input2)
    {
      return (double)input1 / (double)input2;
    }
  }
}
