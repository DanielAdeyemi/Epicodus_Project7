namespace Bakery.Models
{
  public class Bread
  {

    public string Loaves { get; set; }

    public Bread(string loaves) 
    {
      Loaves = loaves;
    }
    public int FinalPrice()
    {
      try
      {
        int number = int.Parse(Loaves);
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

    public string Pastries { get; set; }

    public Pastry(string pastries)
    {
      Pastries = pastries;
    }
    
    public int FinalPrice()
    {
      try
      {
        int number = int.Parse(Pastries);
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