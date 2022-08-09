using NUnit.Framework;
using Game;

namespace Game.Tests
{
  // [TestFixture]
  public class GameTests {
    [Test]
    [TestCase("word1")]
    public void Game_GetWordToGuess_ReturnsWordToGuess(string word)
    {
      // Arrange
      Game game = new Game();

      //Act
      string actual = game.GetWordToGuess(word);
      string expected = word;

      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
