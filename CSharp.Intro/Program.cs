using System; // <- imports classes, such as `Console` that are defined in the `System` namespace

namespace CSharp.Intro // <- a container (or scope) for classes
{
  internal class Program // <- this is a class
  {
    static void Main(string[] args) // <- static methods are like Ruby's class methods
    // void means that this method returns nothing
    // the main method takes an array of strings as an arg - `string[]`
    {
      Console.WriteLine("Hello Makers!"); // <- the main method is called automatically when you execute the program
      new Calculator().Calculate();
    }
  }

  class Calculator
  {
    public void Calculate()
    {
      int result = 2 + 2; // <- we have to declare a type (int) for the variable (result)
      Console.WriteLine("The result is {0:d}", result);
    }
  }
}
