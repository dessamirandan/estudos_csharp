#nullable disable
﻿using System; //
using System.Globalization; //Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); para selecionar casas apos a virgula

namespace PrimeiroProjeto //Nome da aplicão
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string name = "Andressa"; // tipo nome = valor;
      char sexo = 'f';
      double altura = 1.71433;
      int idade = 28;
      Console.WriteLine("Olá, " + name + ". Você possui " + idade + " anos, de sexo " + sexo + ", e uma altura de " + altura); //Exibe um texto + variável

      double x = 10.1234566;
      Console.WriteLine(); //exibe m uma nova linha
      Console.WriteLine(x); //todos numeros apos o ponto
      Console.WriteLine(x.ToString("F2")); //duas casas
      Console.WriteLine(x.ToString("F4")); //quatro casas
      Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));//imprime com o separador ponto
    }
  }
}