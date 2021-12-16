using System;

namespace aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char opcao = ' ';

            Console.WriteLine("São Paulo / Rio de Janeiro");
            Console.WriteLine("Escolha o tranporte: [a]Avião [c]Carro [o]Onibus");

            opcao = char.Parse(Console.ReadLine());

            if (opcao != 'a' && opcao != 'c' && opcao != 'o')
            {
                Console.WriteLine("Opção de transpote invalida");
            }

            switch (opcao)
            {
                case 'a':
                case 'A':
                    tempo = 1 * 60;
                    break;
                case 'c':
                case 'C':
                    tempo = 8 * 60;
                    break;
                case 'o':
                case 'O':
                    tempo = 11 * 60;
                    break;
                default:
                    tempo = -1;
                    break;
            }

            if (tempo < 0)
            {
                Console.WriteLine("Tranporte não informado");
            }
            else
            {
                Console.WriteLine("O tempo informado para a viagem e de {0}", tempo);
            }

        }
    }
}
