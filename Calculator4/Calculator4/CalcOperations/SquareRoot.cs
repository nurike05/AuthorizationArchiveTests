using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator4.CalcOperations
{
  public class SquareRoot
  {
    public double MakeSquareRoot(object x)
    {
      CSharpCalculator.Calculator calculator = new CSharpCalculator.Calculator();
      return (double)calculator.Sqrt(x);
    }
  }
}
