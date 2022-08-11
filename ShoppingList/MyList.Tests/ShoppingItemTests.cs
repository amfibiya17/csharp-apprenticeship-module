namespace MyList.Tests;

public class ShoppingItemTests
{
  [Test]
  [TestCase("Item1", 4.99)]
  public void This_Class_Holds_Two_Properties_Checking_Name(string itemName, double itemPrice) 
  {
    // Arrange
    ShoppingItem item = new ShoppingItem(itemName, itemPrice);

    // Act
    string actual = item.name;
    string expected = itemName;

    // Assert
    Assert.AreEqual(actual, expected);
  }

  [Test]
  [TestCase("Item1", 4.99)]
  public void This_Class_Holds_Two_Properties_Checking_Price(string itemName, double itemPrice) 
  {
    // Arrange
    ShoppingItem item = new ShoppingItem(itemName, itemPrice);

    // Act
    double actual = item.price;
    double expected = itemPrice;

    // Assert
    Assert.AreEqual(actual, expected);
  }
}