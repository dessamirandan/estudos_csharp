using System;
using System.Globalization;

namespace URI1035
{
  public class Program
  {
    static void Main(string[] args)
    {
      /*Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

Entrada

Quatro números inteiros A, B, C e D.

Saída

Mostre a respectiva mensagem após a validação dos valores.*/
      int A, B, C, D;
      string[] Valores = Console.ReadLine().Split(' ');

      A = int.Parse(Valores[0]);
      B = int.Parse(Valores[1]);
      C = int.Parse(Valores[2]);
      D = int.Parse(Valores[3]);

      if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
      {
        Console.WriteLine("Valores aceitos");
      }
      else
      {
        Console.WriteLine("Valores nao aceitos");
      }
    }
  }
}
