using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator4.CalcOperations
{
  public class Substraction
  {
    public double Substract(object x, object y)
    {
      CSharpCalculator.Calculator calculator = new CSharpCalculator.Calculator();
      return (double)calculator.Sub(x, y);
    }
  }
}
