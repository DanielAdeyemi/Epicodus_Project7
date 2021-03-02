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
      Assert.AreEqual(1, price);
    }

    [TestMethod]
    public void PastryConstractor_ReturnPrice_Int()
    {
      int price = Pastry.FinalPrice("");
      Assert.AreEqual(2, price);
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
  }
}