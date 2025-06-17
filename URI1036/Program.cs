using System;
using System.Globalization;

class URI {

  static void Main(string[] args)
  {

    /**
     * Escreva a sua solução aqui
     * Code your solution here
     * Escriba su solución aquí
     */

    double A, B, C, delta, r1, r2;

    String[] vetor = Console.ReadLine().Split(' ');

     A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
     B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
     C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

    delta = Math.Pow(B, 2.0) - 4 * A * C;

    if (A == 0 || delta < 0.0)
    {
      Console.Write("Impossivel calcular");
    }
    else
    {
      r2 = (-B - Math.Sqrt(delta)) / (2 * A);
      r1 = (-B + Math.Sqrt(delta)) / (2 * A);
      Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
    }


  }

}