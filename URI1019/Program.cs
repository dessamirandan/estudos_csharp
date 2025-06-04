#nullable disable
﻿using System;
using System.Globalization;

namespace URI1019 {
  public class Program
  {
    static void Main(string[] args)
    {
      /*Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

      Entrada

      O arquivo de entrada contém um valor inteiro N.

      Saída

      Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.*/
      int N, horas, minutos, segundos;
      N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      horas = N / 3600;
      minutos = (N % 3600) / 60;
      segundos = N % 60;


      Console.WriteLine(horas + ":" + minutos + ":" + segundos);

    }
    }
}