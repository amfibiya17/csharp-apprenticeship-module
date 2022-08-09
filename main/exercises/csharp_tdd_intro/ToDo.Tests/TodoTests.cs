namespace ToDo.Tests
{
  public class ToDoTests
  {
    [Test]
    public void Setup_Test() {
      Assert.Pass();
    }

    [Test]
    public void Initializes_Empty_List_Of_Tasks()
    {
      // Arrange
      ToDo todo = new ToDo();

      // Assert
      Assert.AreEqual(todo.list, new List<string>());
    }

    [Test]
    [TestCase("task1")]
    [TestCase("task2")]
    public void Adds_New_Task_To_The_List(string task)
    {
      // Arrange
      ToDo todo = new ToDo();

      // Act
      todo.AddTasks(task);
      List<string> actual = todo.list;
      List<string> expected = new List<string>() { task };

      // Assert
      Assert.AreEqual(actual, expected);
    }

    [Test]
    [TestCase("task1")]
    [TestCase("task2")]
    public void Returning_List_Of_Tasks(string task)
    {
      // Arrange
      ToDo todo = new ToDo();

      // Act
      todo.AddTasks(task);
      List<string> actual = todo.list;
      List<string> expected = new List<string>() { task };
      todo.GetTasks();

      // Assert
      Assert.AreEqual(actual, expected);
    }
  }
}
