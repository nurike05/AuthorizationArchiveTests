using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator4.CalcOperations
{
  public class Division
  {
    public double Divide(double x, double y)
    {
      CSharpCalculator.Calculator calculator = new CSharpCalculator.Calculator();
      return calculator.Divide(x, y);
    }
  }
}
