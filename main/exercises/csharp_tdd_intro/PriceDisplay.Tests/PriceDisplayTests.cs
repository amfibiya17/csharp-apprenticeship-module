namespace PriceDisplay.Tests
{
  public class PriceDisplayTests
  {

    [Test]
    public void Setup_Test() {
      Assert.Pass();
    }

    [Test]
    [TestCase(1, "name1")]
    [TestCase(2, "name2")]
    [TestCase(3, "name3")]
    [TestCase(4, "name4")]
    [TestCase(5, "name5")]
    public void GetPrice_and_Name_ofTheItem(int price, string name)
    {
      // Arrange
      PriceDisplay priceDisplay = new PriceDisplay();

      // Act
      string actual = priceDisplay.GetPriceLabel(price, name);
      string expected = $"The price for item: {name} is {price}";

      // Assert
      Assert.AreEqual(actual, expected);
    }
  }
}
