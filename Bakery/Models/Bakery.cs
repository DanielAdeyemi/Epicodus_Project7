namespace Bakery.Models
{
  public class Bread
  {

    public string Loaves { get; }

    public Bread(string loaves) 
    {
      Loaves = loaves;
    }
    public static int FinalPrice(string loaves)
    {
      try
      {
        int number = int.Parse(loaves);
        if (number <= 0)
        {
          throw new System.Exception();
        }
        number = ((number / 3) * 2 + number % 3) * 5;
        return number;
      }
      catch (System.Exception)
      {
        return 0;
      }
    }
  }

  public class Pastry
  {

    public string Pastries { get; }

    public Pastry(string pastries)
    {
      Pastries = pastries;
    }
    
    public static int FinalPrice(string pastries)
    {
      try
      {
        int number = int.Parse(pastries);
        if (number <= 0)
          {
            throw new System.Exception();
          }
        number = number * 2 - number / 3;
        return number;
      }
      catch (System.Exception)
      {
        return 0;
      }
    }
  }
}