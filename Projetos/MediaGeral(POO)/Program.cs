using System;
using System.Linq;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string isNalunos;
            string isNprovas;
            bool validAlunos = true;
            bool validProvas = false;
            int nAlunos;
            int provas;
            double mediaGeral = 0;
            double resultFinal = 0;

            Console.Title = "---- Media Geral de Alunos ----";

            while (validAlunos)
            {
                Console.WriteLine("---- Media Geral de Alunos ----");
                Console.Write("Quantos alunos matriculados? ");
                isNalunos = Console.ReadLine();
                if (isNalunos.All(char.IsDigit))
                {
                    nAlunos = int.Parse(isNalunos);

                    Aluno[] alunos = new Aluno[nAlunos];

                    for (int i = 0; i < alunos.Length; i++)
                    {
                        Console.Clear();
                        Console.Write($"Nome do {i + 1}º Aluno: ");
                        nome = Console.ReadLine();
                        Console.Write($"Quantidade de provas feitora pelo aluno {nome}: ");
                        while (validProvas = true)
                        {
                            isNprovas = Console.ReadLine();
                            if (isNprovas.All(char.IsDigit))
                            {
                                provas = Convert.ToInt32(isNprovas);
                                alunos[i] = new Aluno(nome, provas);
                                Console.WriteLine($"Insira as notas do aluno {nome}");
                                alunos[i].InserirNotas();
                                validProvas = true;
                            }
                            else
                            {
                                Console.Write("Valor informado incorreto insira novamente: ");
                                validProvas = false;
                            }
                        }



                    }
                    Console.Clear();

                    foreach (Aluno aluno in alunos)
                    {
                        Console.WriteLine($"Aluno: {aluno.Nome}");
                        Console.WriteLine($"Media: {aluno.Media}");
                        Console.WriteLine("---------------------------");
                        mediaGeral += aluno.Media;
                    }
                    resultFinal = mediaGeral / alunos.Length;
                    Console.WriteLine($"Media geral dos alunos: {resultFinal}");
                    validAlunos = false;
                }
                else
                {
                    validAlunos = true;
                    Console.Clear();
                }
            }


        }
    }
}
