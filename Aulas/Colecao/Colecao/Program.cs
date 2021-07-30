using System;

namespace Colecao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array unidimensional
            //int[] valor = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //for (int i = 0; i < valor.Length; i++)
            //{
            //    Console.Write(valor[i]);
            //}
            #endregion

            #region array bidimensional

            //int linha = 0, coluna = 0;

            //Console.WriteLine("--------------------");
            //Console.WriteLine("Gerador de tabelas");
            //Console.WriteLine("--------------------");

            //inicio_linha:
            
            //try
            //{
            //    Console.Write("Informe o tamanho da linha: ");
            //    linha = int.Parse(Console.ReadLine());
                
            //}
            //catch
            //{
                
            //    goto inicio_linha;
            //}

            //inicio_coluna:
            //try
            //{
            //    Console.Write("Informe o tamanho da coluna: ");
            //    coluna = int.Parse(Console.ReadLine());
            //}
            //catch
            //{
            //    goto inicio_coluna;
            //}

            //int[,] valores = new int[linha, coluna];
            //Random numRand = new Random();

            //for (int l = 0; l < valores.GetLength(0); l++)
            //{
            //    for (int c = 0; c < valores.GetLength(1); c++)
            //    {
            //        valores[l, c] = numRand.Next(10);
            //        Console.Write($"[{valores[l, c]}]");
            //    }
            //    Console.Write("\n");
            //}

            #endregion
        }
    }
}
