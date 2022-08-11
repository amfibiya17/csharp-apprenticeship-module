using System.Net.Http;
using MyList;
using NUnit.Framework;

namespace MyList.Tests;

public class MyListTests
{
  [Test]
  public void Initializes_Empty_List_Of_Item_Names()
  {
    // Arrange
    MyList myList = new MyList();

    // Assert
    Assert.AreEqual(myList.list, new List<ShoppingItem>());
  }

  [Test]
  [TestCase("Item1", 2.22)]
  [TestCase("Item2", 1.22)]
  public void It_Has_AddItem_Method_WhichAdds_a_String_To_aListOfItems(string itemName, double itemPrice)
  {
    // Arrange
    MyList myList = new MyList();
    ShoppingItem shoppingItem = new ShoppingItem(itemName, itemPrice);

    // Act
    myList.AddItem(shoppingItem);
    List<ShoppingItem> actual = myList.list;
    List<ShoppingItem> expected = new List<ShoppingItem>() { shoppingItem };

    // Assert
    Assert.AreEqual(actual, expected);
  }

  [Test]
  [TestCase("Item1", 2.22)]
  [TestCase("Item2", 1.22)]
  public void It_Has_GetItem_Method_Which_Returns_aListOfItems(string itemName, double itemPrice)
  {
    // Arrange
    MyList myList = new MyList();
    ShoppingItem shoppingItem = new ShoppingItem(itemName, itemPrice);

    // Act
    myList.AddItem(shoppingItem);
    List<ShoppingItem> actual = myList.GetItems();
    List<ShoppingItem> expected = new List<ShoppingItem>() { shoppingItem };

    // Assert
    Assert.AreEqual(actual, expected);
  }
}