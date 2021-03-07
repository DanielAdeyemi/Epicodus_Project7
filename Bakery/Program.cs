using static System.Console;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      WriteLine("Welcome to the Pierre's Bakery! We would like to offer you Pastry or Bread at this time."); 
      WriteLine("We have some amazing deals for you: ");
      WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
      WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
      WriteLine("If you are interested and want to choose optinons for price estimation, please type 'Y', otherwise, type any character");
      if (!ReadLine().ToUpper().Equals("Y"))
      {
        WriteLine("We hope you will find something you are looking for next time!");
      }
      else
      {
        WriteLine("How many loaves of bread do you want? ");
        Bread newBread = new Bread(ReadLine());
        WriteLine("How many pastries do you want? ");
        Pastry newPastry = new Pastry(ReadLine());
        int price = newBread.FinalPrice() + newPastry.FinalPrice();
        if (price == 0)
        {
          WriteLine("I am afraid you input 0 or something invalid. Try again!");
        }
        else
        {
          WriteLine($"Total price of your order will be ${price}. Hope to see you soon!");
        }
      }
    }
  }
}