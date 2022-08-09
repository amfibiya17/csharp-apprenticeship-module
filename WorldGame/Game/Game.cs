using System;
using System.Text;

namespace Game{
  public class Game
  {
    string wordToGuess;
    public Game(string word) 
    {
      wordToGuess = word;
    }

    
    public string GetWordToGuess() 
    {
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
  }
}
