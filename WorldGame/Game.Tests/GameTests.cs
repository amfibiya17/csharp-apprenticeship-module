using NUnit.Framework;
using Game;
using NSubstitute;

namespace Game.Tests
{
  // [TestFixture]
  public class GameTests {
    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess()
    {
      // Arrange
      WordChoser mockWordChoser = Substitute.For<WordChoser>();
      mockWordChoser.GetRandomWordFromDictionary().Returns("DEVELOPER");
      Game game = new Game(mockWordChoser);

      // Act
      string actual = game.GetWordToGuess();
      string expected = "D________";

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Game_GetRemainingAttempts()
    {
      // Arrange
      WordChoser wordChoser = new WordChoser();
      Game game = new Game(wordChoser);

      // Act
      game.GetWordToGuess();
      int actual = game.GetRemainingAttempts();
      int expected = 10;

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Game_GuessLetter_False()
    {
      // Arrange
      WordChoser mockWordChoser = Substitute.For<WordChoser>();
      mockWordChoser.GetRandomWordFromDictionary().Returns("DEVELOPER");
      Game game = new Game(mockWordChoser);

      // Act
      bool actual = game.GuessLetter('T');
      bool expected = false;
      
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Game_GuessLetter_True()
    {
      // Arrange
      WordChoser mockWordChoser = Substitute.For<WordChoser>();
      mockWordChoser.GetRandomWordFromDictionary().Returns("DEVELOPER");
      Game game = new Game(mockWordChoser);

      // Act
      bool actual = game.GuessLetter('D');
      bool expected = true;
      
      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
