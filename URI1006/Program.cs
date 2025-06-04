#nullable disable
﻿using System; //funções básicas como Console.WriteLine()
using System.Globalization; //garante que a vírgula decimal seja tratada como ponto, útil para dados no padrão americano.

namespace URI1006 //Define o namespace, que organiza o código e evita conflitos de nomes em programas maiores.
{
  public class Program //Define a classe principal. Program é o nome padrão, mas pode ser qualquer nome.
  {
    static void Main(string[] args) //Método principal: é onde a execução do programa começa.
    {
      /*Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

      Entrada

      O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

      Saída

      Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error"*/
      double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Lê três valores double da entrada, utilizando CultureInfo.InvariantCulture para garantir que o . seja aceito como separador decimal.

      double MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10; //Calcula a média ponderada

      Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture)); //Exibe o resultado com 1 casa decimal, com ponto como separador
      //Console.WriteLine($"MEDIA = {MEDIA:F1}", CultureInfo.InvariantCulture);


    }
  }
}