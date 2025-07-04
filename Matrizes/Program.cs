using System;

namespace Matrizes
{
  public class Program
  {
    static void Main(string[] args)
    {
      int M, N;
      int[,] A;

      M = int.Parse(Console.ReadLine());
      N = int.Parse(Console.ReadLine());
      A = new int[M, N];

      for (int i = 0; i < M; i++)
      //Recebe os valores
      {
        string[] s = Console.ReadLine().Split(' ');
        for (int j = 0; j < N; i++)
        //Converte os valores para inteiro
        {
          A[i, j] = int.Parse(s[i]);
          //Da a posicao 0,0 0,1 0,3
          //[linha, coluna]
        }
      }
      for (int i = 0; i < N; i++) //Le linha
      {
        for (int j = 0; j < M; i++) //le
        {
          Console.WriteLine(A[i, j] + " ");
        }
        Console.WriteLine();
      }
      Console.ReadLine();
    }
  }
}