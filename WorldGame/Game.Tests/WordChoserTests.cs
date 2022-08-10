using NUnit.Framework;
using Game;

namespace Game.Tests
{
  public class WordChoserTests {
    [Test]
    public void WordChoser_GetRandomWordFromDictionary()
    {
      // Arrange
      WordChoser wordChoser = new WordChoser();

      // Act
      string actual = wordChoser.GetRandomWordFromDictionary();
      string expected = "Test";

      // Assert
      Assert.AreEqual(actual, expected);
    }
  }
}