namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
  [Test]
  [TestCase(1, "1")]
  [TestCase(4, "4")]
  [TestCase(7, "7")]
  [TestCase(11, "11")]
  [TestCase(13, "13")]
  public void For_NumbersNotDivisibleByThreeOrFive_ReturnTheNumber(int input, string output)
  {
    // Arrange
    FizzBuzz fizzBuzz = new FizzBuzz();

    // Act
    string actual = fizzBuzz.For(input);
    string expected = output;

    // Assert
    Assert.AreEqual(actual, expected);
  }

  [Test]
  [TestCase(3, "Fizz")]
  [TestCase(6, "Fizz")]
  [TestCase(9, "Fizz")]
  [TestCase(12, "Fizz")]
  public void For_NumbersDivisibleByThree_ReturnFizz(int input, string output)
  {
    // Arrange
    FizzBuzz fizzBuzz = new FizzBuzz();

    // Act
    string actual = fizzBuzz.For(input);
    string expected = output;

    // Assert
    Assert.AreEqual(actual, expected);
  }

  [Test]
  [TestCase(5, "Buzz")]
  [TestCase(10, "Buzz")]
  [TestCase(20, "Buzz")]
  [TestCase(25, "Buzz")]
  public void For_NumbersDivisibleByFive_ReturnBuzz(int input, string output)
  {
    // Arrange
    FizzBuzz fizzBuzz = new FizzBuzz();

    // Act
    string actual = fizzBuzz.For(input);
    string expected = output;

    // Assert
    Assert.AreEqual(actual, expected);
  }
}