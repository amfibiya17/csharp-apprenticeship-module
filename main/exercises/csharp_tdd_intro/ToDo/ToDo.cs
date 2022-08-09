using System.Collections.Generic;
using System;

namespace ToDo
{
  public class ToDo
  {
    public List<string> list;

    public ToDo() // <- constructor of the class
    {
      list = new List<string>();
    }

    public void AddTasks(string task)
    {
      list.Add(task);
    }

    public List<string> GetTasks()
    {
      return list;
    }
  }
}
