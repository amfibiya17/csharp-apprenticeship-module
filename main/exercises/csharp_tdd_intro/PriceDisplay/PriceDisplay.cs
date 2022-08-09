using System;

namespace PriceDisplay
{
  public class PriceDisplay
  {
    public string GetPriceLabel(int price, string name)
    {
      string result = $"The price for item: {name} is {price}";
      return result;
    }
  }
}
