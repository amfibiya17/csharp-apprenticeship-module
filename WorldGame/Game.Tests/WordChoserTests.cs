using NUnit.Framework;
using Game;
using NSubstitute;

namespace Game.Tests
{
  public class WordChoserTests {
    [Test]
    public void WordChoser_GetRandomWordFromDictionary()
    {
      WordChoser wordChoser = new WordChoser();
      string[] DICTIONARY = new string[] {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};

      string result = wordChoser.GetRandomWordFromDictionary();

      Assert.IsTrue(DICTIONARY.Contains(result));
    }
  }
}