using System.Collections.Generic;
using System;

namespace MyList
{
  public class MyList
  {
    // ShoppingItem shoppingItem;
    public List<ShoppingItem> list;
    public MyList() // <- constructor of the class
    {
      list = new List<ShoppingItem>();
    }

    public void AddItem(ShoppingItem shoppingItem)
    {
      list.Add(shoppingItem);
    }

    public List<ShoppingItem> GetItems()
    {
      return list;
    }
  }
}
