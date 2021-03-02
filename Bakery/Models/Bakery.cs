using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public static int FinalPrice(string input)
      {
        try
				{
					int number = int.Parse(input);
					return 5;
				}
				catch (System.Exception)
				{	
					return 1;
				}
				// if (!String.IsNullOrEmpty(input)) 
				// {
        //   double price = "Total cost: $5";
        //   return price;
        // }
        // else
        // {
    	  //   double price = "Buy 2, get 1 free. A single loaf costs $5.";
        //   return price.ToString();
        // }
      }
  }

  public class Pastry
  {
    public static int FinalPrice(string input)
    {
      try
      {
        int number = int.Parse(input);
        return 2;
      }
      catch (System.Exception)
      {
        return 2;
      }

    	// if (!String.IsNullOrEmpty(input))
      // {
      //   string price = "Total cost: $2";
      //   return price;
      // }
      // else
      // {
      //   string price = "Buy 1 for $2 or 3 for $5";
      //   return price;
      // }
    }
  }
}