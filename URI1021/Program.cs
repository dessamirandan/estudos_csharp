#nullable disable
﻿using System;
using System.Globalization;

class URI1021
{
    static void Main(string[] args)
    {
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int reais = (int)valor; //armazena apenas o inteiro.
        int centavos = (int)Math.Round((valor - reais) * 100); //pegas os centavos*100, arredonda e converte para int. 500- 573.73 = 0.73*100 = 73.0 = 73

        // NOTAS
        Console.WriteLine("NOTAS:");

        int nota100 = reais / 100;
        reais = reais % 100;

        int nota50 = reais / 50;
        reais = reais % 50;

        int nota20 = reais / 20;
        reais = reais % 20;

        int nota10 = reais / 10;
        reais = reais % 10;

        int nota5 = reais / 5;
        reais = reais % 5;

        int nota2 = reais / 2;
        reais = reais % 2;

        Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
        Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
        Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
        Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
        Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
        Console.WriteLine($"{nota2} nota(s) de R$ 2.00");

        // MOEDAS
        Console.WriteLine("MOEDAS:");

        int moeda1 = reais;

        int moeda050 = centavos / 50;
        centavos = centavos % 50;

        int moeda025 = centavos / 25;
        centavos = centavos % 25;

        int moeda010 = centavos / 10;
        centavos = centavos % 10;

        int moeda005 = centavos / 5;
        centavos = centavos % 5;

        int moeda001 = centavos;

        Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
        Console.WriteLine($"{moeda050} moeda(s) de R$ 0.50");
        Console.WriteLine($"{moeda025} moeda(s) de R$ 0.25");
        Console.WriteLine($"{moeda010} moeda(s) de R$ 0.10");
        Console.WriteLine($"{moeda005} moeda(s) de R$ 0.05");
        Console.WriteLine($"{moeda001} moeda(s) de R$ 0.01");
    }
}
