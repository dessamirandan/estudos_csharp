using System;
using System.Globalization;
using System.Xml.Serialization;

namespace Exercicio
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada

O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída

A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
      */
      string[] pecaUm = Console.ReadLine().Split(' ');
      string[] pecaDois = Console.ReadLine().Split(' ');

      int codigo = int.Parse(pecaUm[0]);
      int codigo2 = int.Parse(pecaDois[0]);

      int numPeca = int.Parse(pecaUm[1]);
      int numPeca2 = int.Parse(pecaDois[1]);

      double valor = double.Parse(pecaUm[2], CultureInfo.InvariantCulture);
      double valor2 = double.Parse(pecaDois[2], CultureInfo.InvariantCulture);

      double soma = (valor * numPeca) + (valor2 * numPeca2);

      Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2"));
    }
  }
}