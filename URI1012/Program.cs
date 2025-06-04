#nullable disable
﻿using System;
using System.Globalization;

namespace URI1012
{
  public class Program
  {
    static void Main(string[] args)
    {
      /*Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
      a) a área do triângulo retângulo que tem A por base e C por altura.
      b) a área do círculo de raio C. (pi = 3.14159)
      c) a área do trapézio que tem A e B por bases e C por altura.
      d) a área do quadrado que tem lado B.
      e) a área do retângulo que tem lados A e B.

      Entrada

      O arquivo de entrada contém três valores com um dígito após o ponto decimal.

      Saída

      O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.*/
      string[] medidas = Console.ReadLine().Split(' '); //recebe lista de vetores em string
      double A = double.Parse(medidas[0], CultureInfo.InvariantCulture);
      double B = double.Parse(medidas[1], CultureInfo.InvariantCulture);
      double C = double.Parse(medidas[2], CultureInfo.InvariantCulture);

      double areaTriangulo = (A * C) / 2;

      double areaCirculo = 3.14159 * Math.Pow(C, 2);

      double areaTrapezio = (((A + B) / 2) * C);

      double areaQuadrado = Math.Pow(B, 2);

      double areaRetangulo = (A * B);

      Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

    }
  }
}