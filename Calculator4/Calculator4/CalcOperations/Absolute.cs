using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator4.CalcOperations
{
  public class Absolute
  {
    public int Abs(object x)
    {
      CSharpCalculator.Calculator calculator = new CSharpCalculator.Calculator();
      return (int)calculator.Abs(x);
    }
  }
}
