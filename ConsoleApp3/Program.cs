#nullable disable
﻿using System;
using System.Globalization;


namespace TerceiroProjeto
{
  internal class Programa
  {
    static void Main(string[] args)
    {

      //string frase = "Estou aprendendo Lógica de Programação.";
      //Console.WriteLine(frase);
      Console.Write("Digite uma frase curta: ");

      string meuTexto = Console.ReadLine(); //aguarda entrada de texto
      Console.WriteLine("Você digitou: " + meuTexto); //imprime o texto escrito na tela


      Console.Write("Digite três frutas: ");
      //string x = Console.ReadLine(); //Testando o comando split
      string[] vet = Console.ReadLine().Split(' '); //string recebe vetores e reconhece na variável x cada varíavel com o espaço em branco
      Console.WriteLine("A primeira fruta é: " + vet[0]);
      Console.WriteLine("A sgeunda fruta é: " + vet[1]);
      Console.WriteLine("A terceira fruta é: " + vet[2]);

      //Novo teste
      Console.Write("Digite um número");
      int num = int.Parse(Console.ReadLine()); // .Parse converte na variável antes do ponto.
                                               //double.Parse int.Parse char.Parse
      Console.Write("Digite sua altura");
      double alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Você digitou: " + num + ". Com :" + alt);

    }
  }
}