using NUnit.Framework;
using Game;

namespace Game.Tests
{
  // [TestFixture]
  public class GameTests {
    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess()
    {
      // Arrange
      Game game = new Game();

      // Act
      string actual = game.GetWordToGuess();
      string expected = "M_____";

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Game_GetRemainingAttempts()
    {
      // Arrange
      Game game = new Game();

      // Act
      game.GetWordToGuess();
      int actual = game.GetRemainingAttempts();
      int expected = 10;

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Game_GetRandomWordFromDictionary()
    {
      // Arrange
      Game game = new Game();

      // Act
      string actual = game.GetRandomWordFromDictionary();
      string expected = "Test";

      // Assert
      Assert.AreEqual(actual, expected);
    }
  }
}
