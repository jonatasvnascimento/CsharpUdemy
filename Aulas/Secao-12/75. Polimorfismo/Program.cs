using System;

namespace _75._Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forma b = new Triangulo();
            Forma c = new Circulo();
            Forma d = new Retangulo();

            b.Desenhar();
            c.Desenhar();
            d.Desenhar();

        }
    }
}
