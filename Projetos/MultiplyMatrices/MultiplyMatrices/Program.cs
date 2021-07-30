using System;

namespace MultiplyMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] result = new int[2, 2];
            string resp = "";

        inicio:
            Console.Clear();

            Random numRand = new Random();

            Console.WriteLine("Prencher Matriz 1: ");


            //leitura de valores
            for (int linha = 0; linha < matriz1.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz1.GetLength(1); coluna++)
                {
                    matriz1[linha, coluna] = numRand.Next(10); /*int.Parse(Console.ReadLine());*/
                    Console.Write($"[{linha}][{coluna}]:{ matriz1[linha, coluna]} ");
                    Console.Write("\n");
                }
            }

            Console.WriteLine("Prencher Matriz 2: ");

            for (int linha = 0; linha < matriz2.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz2.GetLength(1); coluna++)
                {
                    matriz2[linha, coluna] = numRand.Next(10);/*int.Parse(Console.ReadLine());*/
                    Console.Write($"[{linha}]|[{coluna}]: {matriz2[linha, coluna]}");
                    Console.Write("\n");
                }
            }

            Console.Write("\n");
            Console.WriteLine("Resultado Preenchido");
            Console.WriteLine("Matriz 1");

            //resultado dos valores lidos matriz1
            for (int linha = 0; linha < matriz1.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz1.GetLength(1); coluna++)
                {
                    Console.Write($"[{matriz1[linha, coluna]}]");
                }
                Console.Write("\n");
            }

            Console.Write("\n");
            Console.WriteLine("Matriz 2");

            //resultado dos valores lidos matriz2
            for (int linha = 0; linha < matriz2.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz2.GetLength(1); coluna++)
                {
                    Console.Write($"[{matriz2[linha, coluna]}]");
                }
                Console.Write("\n");
            }

            Console.Write("\n");
            Console.WriteLine("Resultado da soma de matrizes");

            result[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            result[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            result[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            result[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            for (int linha = 0; linha < result.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < result.GetLength(1); coluna++)
                {
                    Console.Write($"[{result[linha, coluna]}]");
                }
                Console.Write("\n");
            }

            Console.Write("Deseja ver mais resultados?(s/n)  ");
            resp = Console.ReadLine().ToLower();

            if (resp == "s")
            {
                goto inicio;
            }
            else
            {
                Environment.Exit(0);
            }

        }
    }
}
