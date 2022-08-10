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

    [Test]
    [TestCase('T', 9)]
    [TestCase('Y', 9)]
    [TestCase('Z', 9)]
    [TestCase('D', 10)]
    [TestCase('E', 10)]
    [TestCase('R', 10)]
    public void Game_GuessLetter_Counter(char letter, int counter)
    {
      // Arrange
      WordChoser mockWordChoser = Substitute.For<WordChoser>();
      mockWordChoser.GetRandomWordFromDictionary().Returns("DEVELOPER");
      Game game = new Game(mockWordChoser);

      // Act
      game.GuessLetter(letter);
      int actual = game.counter;
      int expected = counter;
      
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCase('D')]
    [TestCase('E')]
    [TestCase('R')]
    public void Game_GuessLetter_guessedLetters(char letter)
    {
      // Arrange
      WordChoser mockWordChoser = Substitute.For<WordChoser>();
      mockWordChoser.GetRandomWordFromDictionary().Returns("DEVELOPER");
      Game game = new Game(mockWordChoser);

      // Act
      game.GuessLetter(letter);
      List<char> actual = game.guessedLetters;
      List<char> expected = new List<char>() { letter };
      
      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
