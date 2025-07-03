using System;

namespace URI1071
{
  public class Program
  {
    static void Main(string[] args)
    {
      int X, Y, SOMA;
      X = int.Parse(Console.ReadLine());
      Y = int.Parse(Console.ReadLine());
      SOMA = 0;

      for (int i = Math.Min(X, Y) + 1; i < Math.Max(X, Y); i++)
      {
        if (i % 2 != 0)
        {
          SOMA = SOMA + i;
        }
      }
        Console.WriteLine(SOMA);
    }
  }
}

