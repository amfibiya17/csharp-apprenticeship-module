using System;
using System.Text;

namespace Game{
  public class Game
  {
    public int counter;
    public string wordToGuess;
    public List<char> guessedLetters;
    public Game(WordChoser wordChoser) // <- it means that you need to give a WordChoser(type) when you create a game and we will call it wordChoser
    {
      counter = 10;
      wordToGuess = wordChoser.GetRandomWordFromDictionary(); //<- assign the result of the method on the injected dependency
      guessedLetters = new List<char>();
    }

    public string GetWordToGuess() 
    {
      StringBuilder clue = new StringBuilder();
      for (int i = 0; i < wordToGuess.Length; i++)
      {
        if (i == 0 || guessedLetters.Contains(wordToGuess[i]))
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

    public bool GuessLetter(char letter) {
      if (wordToGuess.IndexOf(letter) == - 1) {
        counter -= 1;
        return false;
      } else {
        guessedLetters.Add(letter);
        return true;
      }
    }
    public bool IsGameWon()
    {
      for (int i = 1; i < wordToGuess.Length; i ++)
      {
        if (!guessedLetters.Contains(wordToGuess[i])) 
        {
          return false;
        }
      }
      return true;
    }

    public bool IsGameLost()
    {
      if (counter == 0)
      {
        return true;
      } else{
        return false;
      }
    }
  }
}
