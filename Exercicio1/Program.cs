using System;
using System.Globalization;

namespace ExercicioUm
{
  internal class Programa
  {
    static void Main(string[] args)
    {
      /* Entre com seu nome completo:
      Alex Green
      Quantos quartos tem na sua casa?
      3
      Entre com o preço de um produto:
      500.50
      Entre seu último nome, idade e altura (mesma linha):
      Green 21 1.73 */

      /* SAÍDA ESPERADA (NÚMEROS REAIS COM DUAS CASAS DECIMAIS):
        Alex Green
        3
        500.50
        Green
        21 1.73*/
      Console.Write("Entre com seu nome completo: ");
      string nomeCompleto = Console.ReadLine();


      Console.Write("Quantos quartos tem na sua casa? ");
      int quartos = int.Parse(Console.ReadLine());

      Console.Write("Entre com o preço do produto: Ex. 1.20 ");
      double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Tipo.converte, (Recebe, muda padrao)

      Console.Write("Entre com seu último nome, idade e altura (mesma linha e separado por espaço): ");
      string[] dados = Console.ReadLine().Split(' '); //recebe lista de vetores.separados por espaço
      string ultimoNome = dados[0];
      int idade = int.Parse(dados[1]);
      double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);


      //Resultados
      Console.WriteLine(nomeCompleto);
      Console.WriteLine(quartos);
      Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture)); //Variavel.Duas casas, Padrao
      Console.WriteLine(ultimoNome);
      Console.Write(idade);
      Console.Write(altura.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}