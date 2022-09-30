using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator4.CalcOperations
{
  public class Multiplication
  {
    public double Multiply(double x, double y)
    {
      CSharpCalculator.Calculator calculator = new CSharpCalculator.Calculator();
      return calculator.Multiply(x, y);
    }
  }
}
