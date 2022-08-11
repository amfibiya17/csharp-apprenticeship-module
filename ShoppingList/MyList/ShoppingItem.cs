using System.Collections.Generic;
using System;

namespace MyList
{
  public class ShoppingItem
  {
    public string name;
    double price;
    public ShoppingItem(string itemName, double itemPrice)
    {
      name = itemName;
      price = itemPrice;
    }
  }
}