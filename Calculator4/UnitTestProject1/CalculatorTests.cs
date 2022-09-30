using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
  [TestClass]
  public class CalculatorTests
  {
    [Ignore]
    [TestMethod]
    public void Add_Five_to_Three_Is_Eight()
    {
      //arrange
      Calculator4.CalcOperations.Addition addition = new Calculator4.CalcOperations.Addition();
      var x = 5;
      var y = 3;
      //act
      var actualResult = addition.Add(x, y);
      var expectedResult = 8;
      //assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void Substract_Five_Minus_Three_Is_Two()
    {
      //arrange
      Calculator4.CalcOperations.Substraction substraction = new Calculator4.CalcOperations.Substraction();
      var x = 5;
      var y = 3;
      //act
      var actualResult = substraction.Substract(x, y);
      double expectedResult = 2;
      //assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void Multiply_Five_to_Three_Is_Fifteen()
    {
      //arrange
      Calculator4.CalcOperations.Multiplication multiplication = new Calculator4.CalcOperations.Multiplication();
      var x = 5;
      var y = 3;
      //act
      var actualResult = multiplication.Multiply(x, y);
      double expectedResult = 15;
      //assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [DataTestMethod]
    [DataRow(6, 2, 3)]
    [DataRow(-9, 3, -3)]
    [DataRow(60009, 3, 20003)]
    
    public void Divide_Six_to_Three_Is_Two(double a, double b, double expectedResult)
    {
      //arrange
      Calculator4.CalcOperations.Division division = new Calculator4.CalcOperations.Division();
      //act
      var actualResult = division.Divide(a, b);
      //assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void Absolute_Of_TwoPointThree_Is_Two()
    {
      //arrange
      Calculator4.CalcOperations.Absolute absolute = new Calculator4.CalcOperations.Absolute();
      double x = 2.3;
      //act
      var actualResult = absolute.Abs(x);
      double expectedResult = 2;
      //assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void MakeSquareRoot_Of_Nine_Is_Three()
    {
      //arrange
      Calculator4.CalcOperations.SquareRoot squareRoot = new Calculator4.CalcOperations.SquareRoot();
      double x = 9;
      //act
      var actualResult = squareRoot.MakeSquareRoot(x);
      double expectedResult = 3;
      //assert
      Assert.AreEqual(expectedResult, actualResult);
    }
  }
}
