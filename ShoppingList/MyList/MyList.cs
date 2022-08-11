using System.Collections.Generic;
using System;

namespace MyList
{
  public class MyList
  {
    public List<string> list;
    public MyList() // <- constructor of the class
    {
      list = new List<string>();
    }

    public void AddItem(string item)
    {
      list.Add(item);
    }

    public List<string> GetItems()
    {
      return list;
    }
  }
}
