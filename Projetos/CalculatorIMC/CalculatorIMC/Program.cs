using System;
using System.Linq;

namespace CalculatorIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------- Calculo do IMC ----------------------");

            double
                pesoFinal = 0,
                alturaFinal = 0,
                imc = 0;

            string peso = "";
            string altura = "";
            string resp = "";

        informePeso:

            Console.Write("Informe o peso: ");
            peso = Console.ReadLine();

            if (peso == "" || !peso.All(char.IsDigit))
            {
                Console.WriteLine("Peso invalido");
                goto informePeso;
            }
            else
            {
                pesoFinal = double.Parse(peso);
            }

        imformeAltura:

            Console.Write("Informe a altura: ");
            altura = Console.ReadLine();
            if (altura == "")
            {
                Console.WriteLine("Altura invalida");
                goto imformeAltura;

            }
            else
            {
                try
                {
                alturaFinal = double.Parse(altura);
                }
                catch
                {
                    Console.WriteLine("Altura invalida");
                    goto imformeAltura;
                }
            }
           
            imc = pesoFinal / (alturaFinal * alturaFinal);

            if (imc < 18.5)
            {
                Console.WriteLine($"{Math.Round(imc, 1)}: Abaixo do Peso");
            }else if (imc <= 18.5 && imc <= 25)
            {
                Console.WriteLine($"{Math.Round(imc, 1)}: No peso normal");
            }else if (imc <=25 && imc <=30)
            {
                Console.WriteLine($"{Math.Round(imc, 1)}: Acima do peso");
            }
            else
            {
                Console.WriteLine($"{Math.Round(imc, 1)}: Obeso");
            }

            Console.WriteLine("Deseja continuar? [s/n] ");
            resp = Console.ReadLine();
            if (resp == "S" || resp == "s" )
            {
                Console.Clear();
                goto informePeso;
            }
           
            //Console.WriteLine($"{Math.Round(imc, 1)}");


        }
    }
}
