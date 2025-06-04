#nullable disable
﻿using System;
using System.Globalization;

namespace ValorDoTerreno
{
  internal class Programa
  {
    static void Main(string[] args)
    {
      //Criar um programa que calcula o valor de um terreno retangular com duas casas decimais.

      Console.WriteLine("Olá, seja bem vindo ao sistema de calculo de valor do terreno. Você deverá inserir as seguintes informações quando solicitado: Valor do metro quadrado da sua região, a largura e comprimento do seu terreno com as casas decimais separados por ponto (Ex. 100.24).");
      Console.WriteLine("Vamos lá?");
      Console.Write("Digite o valor do metro quadrado da região do seu lote: (Venda Nova 200.00, Centro Sul 500.00, Pampulha 800.00, Norte 250.00, Nordeste 200.00, Noroeste 220.00, Leste 250.00, Barreiro 200.00)");
      double valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Digite a largura do seu lote");
      double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Digite o comprimento do seu lote");
      double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double area = largura * comprimento;
      Console.WriteLine("A área do seu terreno em metros quadrados é: " + area.ToString("F2"), CultureInfo.InvariantCulture);

      double valorTerreno = area * valorMetro;

      Console.WriteLine("O valor do seu terreno é: " + valorTerreno.ToString("F2"), CultureInfo.InvariantCulture);
    }
  }
}

