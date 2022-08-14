using System;

namespace FizzBuzz 
{
  public class FizzBuzz
  {
    public string For(int number)
    {
      if (number % 3 == 0)
      {
        return "Fizz";
      }
      else if (number % 5 == 0)
      {
        return "Buzz";
      }
      return number.ToString();
    }
  }
}