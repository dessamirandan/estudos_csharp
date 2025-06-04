#nullable disable
﻿using System;
using System.Globalization;

namespace URI1015
{
  public class Program
  {
    static void Main(string[] args)
    {
      /*Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais, segundo a fórmula:

      Entrada

      O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

      Saída

      Calcule e imprima o valor da distância segundo a fórmula fornecida, considerando 4 casas decimais.*/

      string[] dados1 = Console.ReadLine().Split(' ');
      string[] dados2 = Console.ReadLine().Split(' ');

      double x1 = double.Parse(dados1[0], CultureInfo.InvariantCulture);
      double y1 = double.Parse(dados1[1], CultureInfo.InvariantCulture);

      double x2 = double.Parse(dados2[0], CultureInfo.InvariantCulture);
      double y2 = double.Parse(dados2[1], CultureInfo.InvariantCulture);

      double distancia = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

      Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
    }
  }
}