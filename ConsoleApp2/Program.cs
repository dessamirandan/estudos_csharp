#nullable disable
﻿using System;

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

      int x, z;
      double div; // a declaracao da variavel precisa ser condizente ao resultado
      x = 15;
      z = 2;
      //div = x / z; //precisa fazer o casting (double) e declarar como double
      div = (double)x / z;
      Console.WriteLine("O resultado da divisão é: " + div);
    }
  }
}
