namespace MyList.Tests;

public class MyListTests
{
    [Test]
    public void Initializes_Empty_List_Of_Item_Names()
    {
      // Arrange
      MyList myList = new MyList();

      // Assert
      Assert.AreEqual(myList.list, new List<string>());
    }

    
}