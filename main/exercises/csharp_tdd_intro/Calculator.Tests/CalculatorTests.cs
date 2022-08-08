namespace Calculator.Tests
{
  public class CalculatorTests
  {

    [Test] // [Test] <- a special tag, called an attribute which indicates that what follows is a test and that it should be executed as part of the test suite
    public void Setup_Test() { // <- Setup_Test is a regular C# method, which will be executed as a test
      Assert.Pass(); // <- Assert is a class from the nunit framework
    }

    [Test]
    [TestCase(1, 1)]
    [TestCase(1, 2)]
    [TestCase(1, 3)]
    [TestCase(3, 1)]
    public void Add_TwoNumbers_ReturnTotal(int first, int second)
    {
      // Arrange
      Calculator calculator = new Calculator();

      // Act
      int actual = calculator.Add(first, second);
      int expected = first + second;

      // Assert
      Assert.AreEqual(actual, expected);
    }

    [Test]
    [TestCase(1, 2)]
    [TestCase(2, 2)]
    [TestCase(3, 2)]
    [TestCase(4, 10)]
    public void Multiply_TwoNumbers_ReturnProduct(int first, int second)
    {
      // Arrange
      Calculator calculator = new Calculator();

      // Act
      int actual = calculator.Multiply(first, second);
      int expected = first * second;

      // Assert
      Assert.AreEqual(actual, expected);
    }
  }
}