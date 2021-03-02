using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class BakeryTests
  {

    [TestMethod]
    public void BreadConstractor_ReturnPrice_Int()
    {
      int price = Bread.FinalPrice("");
      Assert.AreEqual(0, price);
    }

    [TestMethod]
    public void PastryConstractor_ReturnPrice_Int()
    {
      int price = Pastry.FinalPrice("");
      Assert.AreEqual(0, price);
    }

    [TestMethod]
    public void BreadPriceForOne_ReturnPrice_Int()
    {
      int price = Bread.FinalPrice("1");
      Assert.AreEqual(5, price);
    }

    [TestMethod]
    public void PastryPriceForOne_ReturnPrice_Int()
    {
      int price = Pastry.FinalPrice("1");
      Assert.AreEqual(2, price);
    }

    [TestMethod]
    public void PastryAndBreadPriceForOne_ReturnPrice_Int()
    {
      int pricePastry = Pastry.FinalPrice("1");
      int priceBread = Bread.FinalPrice("1");
      int price = pricePastry + priceBread;
      Assert.AreEqual(7, price);
    }

    [TestMethod]
    public void BreadPriceForTwo_ReturnPrice_Int()
    {
      int price = Bread.FinalPrice("2");
      Assert.AreEqual(10, price);
    }

    [TestMethod]
    public void PastryAndBreadPriceForTwo_ReturnPrice_Int()
    {
      int price = Pastry.FinalPrice("2");
      Assert.AreEqual(4, price);
    }
  
    [TestMethod]
    public void PastryPriceForTwo_ReturnPrice_Int()
    {
      int pricePastry = Pastry.FinalPrice("2");
      int priceBread = Bread.FinalPrice("2");
      Assert.AreEqual(14, pricePastry + priceBread);
    }

    [TestMethod]
    public void BreadPriceForThree_ReturnPrice_Int()
    {
      int price = Bread.FinalPrice("3");
      Assert.AreEqual(10, price);
    }

    [TestMethod]
    public void PastryPriceForThree_ReturnPrice_Int()
    {
      int price = Pastry.FinalPrice("3");
      Assert.AreEqual(5, price);
    }

    [TestMethod]
    public void PastryAndBreadPriceForThree_ReturnPrice_Int()
    {
      int pricePastry = Pastry.FinalPrice("3");
      int priceBread = Bread.FinalPrice("3");
      Assert.AreEqual(15, pricePastry + priceBread);
    }

    [TestMethod]
    public void BreadPriceForTen_ReturnPrice_Int()
    {
      int price = Bread.FinalPrice("10");
      Assert.AreEqual(35, price);
    }

    [TestMethod]
    public void PastryPriceForTen_ReturnPrice_Int()
    {
      int price = Pastry.FinalPrice("10");
      Assert.AreEqual(17, price);
    }
  }
}