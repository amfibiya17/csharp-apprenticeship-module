namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
  [Test]
  [TestCase(1, 1)]
  [TestCase(4, 4)]
  [TestCase(7, 7)]
  [TestCase(11, 11)]
  [TestCase(13, 13)]
  public void ForNumbersNotDivisibleByThreeOrFive_ReturnTheNumber(int input, int output)
  {
    // Arrange
    FizzBuzz fizzBuzz = new FizzBuzz();

    // Act
    int actual = fizzBuzz.For(input);
    int expected = output;

    // Assert
    Assert.AreEqual(actual, expected);
  }
}