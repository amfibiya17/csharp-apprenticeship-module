using System;

namespace Calculator
{
  internal class Program
  {
    static void GetPriceLabel(int price, string name)
    {
      Console.WriteLine($"The price for item: {name} is {price}");
    }
  }
}