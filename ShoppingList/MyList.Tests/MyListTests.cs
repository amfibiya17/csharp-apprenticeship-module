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

    [Test]
    [TestCase("Item1")]
    [TestCase("Item2")]
    public void It_Has_AddItem_Method_WhichAdds_a_String_To_aListOfItems(string item)
    {
      // Arrange
      MyList myList = new MyList();

      // Act
      myList.AddItem(item);
      List<string> actual = myList.list;
      List<string> expected = new List<string>() { item };

      // Assert
      Assert.AreEqual(actual, expected);
    }

    
}