using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius, Kelvin, Fahrenheit, Rankine = 0;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("      Conversor de temperatura");
            Console.WriteLine("---------------------------------------");

            Console.Write("Informe a temperatura em Celsius: ");
            Celsius = Convert.ToDouble(Console.ReadLine());//convert options double.Parce()

            Fahrenheit = (Celsius * 1.8) + 32;
            Kelvin = Celsius + 273.15;
            Rankine = (Celsius * 1.8) + 491.67;

            Console.WriteLine("Fahrenheit: F° {0:f2}", Fahrenheit);
            Console.WriteLine("Kelvin:     K° {0:f2}", Kelvin);
            Console.WriteLine("Rankine:    R° {0:f2}", Rankine);
            Console.WriteLine("Celsius:    C° {0:f2}", Celsius);

        }
    }
}
