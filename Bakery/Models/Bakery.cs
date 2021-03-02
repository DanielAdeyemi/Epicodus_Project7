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
					number = ((number/3)*2 + number%3)*5;
					return number;
				}
				catch (System.Exception)
				{	
					return -1;
				}
      }
  }

  public class Pastry
  {
    public static int FinalPrice(string input)
    {
      try
      {
        int number = int.Parse(input);
				number = number*2 - number/3;
        return number;
      }
      catch (System.Exception)
      {
        return -2;
      }
    }
  }
}