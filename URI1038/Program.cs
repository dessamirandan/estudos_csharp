using System;
using System.Globalization;
using System.Xml.Serialization;

namespace URI1038
{
  public class Program
  {
    static void Main(string[] args)
    {
      int codigo, quantidade;
      double total, pagar;
      String[] pedido = Console.ReadLine().Split(' ');
      codigo = int.Parse(pedido[0], CultureInfo.InvariantCulture);
      quantidade = int.Parse(pedido[1], CultureInfo.InvariantCulture);
      if (codigo == 1)
      {
        total = 4.00;
      }
      else if (codigo == 2)
      {
        total = 4.50;
      }
      else if (codigo == 3)
      {
        total = 5.00;
      }
      else if (codigo == 4)
      {
        total = 2.00;
      }
      else
      {
        total = 1.50;
      }
      pagar = total * quantidade;

      Console.WriteLine("Total: R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));

    }
  }
}