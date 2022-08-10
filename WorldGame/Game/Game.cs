using System;
using System.Text;

namespace Game{
  public class Game
  {
    int counter;
    // string[] DICTIONARY;
    public Game() 
    {
      counter = 10;
      // DICTIONARY = new string[] {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};
    }

    // public int GetCounter
    // {
    //   get
    //   {
    //     return counter;
    //   }
    // }

    public string GetWordToGuess() 
    {
      string wordToGuess = "GetRandomWordFromDictionary()";
      StringBuilder clue = new StringBuilder();
      for (int i = 0; i < wordToGuess.Length; i++)
      {
        if (i == 0)
        {
          clue.Append(wordToGuess[i]);
        } else {
          clue.Append("_");
        }
      }
      return clue.ToString();
    }

    public int GetRemainingAttempts()
    {
      return counter;
    }

    // public string GetRandomWordFromDictionary() {
    //   Random rand = new Random();
    //   return DICTIONARY[rand.Next(DICTIONARY.Length)];
    // }
  }
}
