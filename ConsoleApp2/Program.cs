using System;

namespace SegundoProjeto
{
  internal class Programa
  {
    static void Main(string[] args)
    {
      int a, b, resultado;
      a = 12;
      b = 4;
      resultado = a + b;
      Console.WriteLine("O resultado da soma é: " + resultado);

      float c, d, total;
      c = 1.2f; //indicar para o compilador o tipo da varíavel
      d = 2.8f; //boas práticas de programacão
      total = c + d;
      Console.WriteLine("O resultado da soma é igual a " + total);
    }
  }
}
