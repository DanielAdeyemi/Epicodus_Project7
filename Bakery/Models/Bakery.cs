using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        public static string FinalPrice(string input)
        {
            string price = "Buy 2, get 1 free. A single loaf costs $5.";
            return price.ToString();
        }
    }

    public class Pastry
    {
        public static string FinalPrice(string input)
        {
            string price = "Buy 1 for $2 or 3 for $5";
            return price;
        }
    }
}