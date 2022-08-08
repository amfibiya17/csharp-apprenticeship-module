using System;

namespace Calculator
{
  internal class Program
  {
    static void Main(string[] args)
    {
      new Calculator().Add(2, 1);
      new Calculator().Multiply(3, 4);
    }
  }

  class Calculator
  {
    public void Add(int first, int second)
    {
      int result = first + second;
    }

    public void Multiply(int first, int second)
    {
      int result = first * second;
    }
  }
}