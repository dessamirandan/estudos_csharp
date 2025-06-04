using System;
using System.Globalization;

namespace URI1009
{
  public class Program
  {
    static void Main(string[] args)
    {
      /*Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.

      Entrada

      O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais, representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.

      Saída

      Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.*/

      string nome = Console.ReadLine(); //?ignora valores null
      double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double salarioTotal = totalVendas * 0.15 + salarioFixo;

      Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
