using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        public static string FinalPrice(string input)
        {
            int price = int.Parse(input);
            return price.ToString();
        }
    }
}