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
    public void BreadConstractor_ReturnPrice_String()
    {
      string price = Bread.FinalPrice("1");
      Assert.AreEqual("Buy 2, get 1 free. A single loaf costs $5.", price);
    }
  }
}