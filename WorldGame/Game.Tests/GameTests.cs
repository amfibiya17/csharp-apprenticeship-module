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
      Game game = new Game("MAKERS");

      //Act
      string actual = game.GetWordToGuess();
      string expected = "M_____";

      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
