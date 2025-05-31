using System; //
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
      Console.ReadLine();

    }
  }
}