using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator4
{
  class Program
  {
    static void Main(string[] args)
    {
      CSharpCalculator.Calculator calculator = new CSharpCalculator.Calculator();
      int a = 4;
      int b = 2;
      var result = calculator.Sqrt((int)a);
      Console.WriteLine(result);
      Console.ReadKey();
      
    }


  }
}
