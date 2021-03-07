using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {

    [TestMethod]
    public void BreadConstractor_ReturnPrice_0()
    {
      Bread newBread = new Bread("");
      int price = newBread.FinalPrice();
      Assert.AreEqual(0, price);
    }

    [TestMethod]
    public void PastryConstractor_ReturnPrice_0()
    {
      Pastry newPastry = new Pastry("");
      int price = newPastry.FinalPrice();
      Assert.AreEqual(0, price);
    }

    [TestMethod]
    public void BreadPriceForOne_ReturnPrice_5()
    {
      Bread newBread = new Bread("1");
      int price = newBread.FinalPrice();
      Assert.AreEqual(5, price);
    }

    [TestMethod]
    public void PastryPriceForOne_ReturnPrice_2()
    {
      Pastry newPastry = new Pastry("1");
      int price = newPastry.FinalPrice();
      Assert.AreEqual(2, price);
    }

    [TestMethod]
    public void PastryAndBreadPriceForOne_ReturnPrice_7()
    {
      Bread newBread = new Bread("1");
      Pastry newPastry = new Pastry("1");
      int pricePastry = newPastry.FinalPrice();
      int priceBread = newBread.FinalPrice();
      int price = pricePastry + priceBread;
      Assert.AreEqual(7, price);
    }

    [TestMethod]
    public void BreadPriceForTwo_ReturnPrice_10()
    {
      Bread newBread = new Bread("2");
      int price = newBread.FinalPrice();
      Assert.AreEqual(10, price);
    }

    [TestMethod]
    public void PastryAndBreadPriceForTwo_ReturnPrice_4()
    {
      Pastry newPastry = new Pastry("2");
      int price = newPastry.FinalPrice();
      Assert.AreEqual(4, price);
    }
  
    [TestMethod]
    public void PastryPriceForTwo_ReturnPrice_14()
    {
      Bread newBread = new Bread("2");
      Pastry newPastry = new Pastry("2");
      int pricePastry = newPastry.FinalPrice();
      int priceBread = newBread.FinalPrice();
      Assert.AreEqual(14, pricePastry + priceBread);
    }

    [TestMethod]
    public void BreadPriceForThree_ReturnPrice_10()
    {
      Bread newBread = new Bread("3");
      int price = newBread.FinalPrice();
      Assert.AreEqual(10, price);
    }

    [TestMethod]
    public void PastryPriceForThree_ReturnPrice_5()
    {
      Pastry newPastry = new Pastry("3");
      int price = newPastry.FinalPrice();
      Assert.AreEqual(5, price);
    }

    [TestMethod]
    public void PastryAndBreadPriceForThree_ReturnPrice_15()
    {
      Bread newBread = new Bread("3");
      Pastry newPastry = new Pastry("3");
      int pricePastry = newPastry.FinalPrice();
      int priceBread = newBread.FinalPrice();
      Assert.AreEqual(15, pricePastry + priceBread);
    }

    [TestMethod]
    public void BreadPriceForTen_ReturnPrice_35()
    {
      Bread newBread = new Bread("10");
      int price = newBread.FinalPrice();
      Assert.AreEqual(35, price);
    }

    [TestMethod]
    public void PastryPriceForTen_ReturnPrice_17()
    {
      Pastry newPastry = new Pastry("10");
      int price = newPastry.FinalPrice();
      Assert.AreEqual(17, price);
    }
  }
}