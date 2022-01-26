using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75._Polimorfismo
{
    abstract public class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; private set; }
        public int Largura { get; private set; }
        public int Raio { get; private set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Desenhar");
        }
        public virtual void Area()
        {
            int area = Largura * Altura;
            Console.WriteLine($"Area do Retangulo: {area}");
        }
    }
    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Circulo");
        }
        public override void Area()
        {
            double area = Math.PI * (Raio * Raio);
            Console.WriteLine($"Area Circulo: {area}");
        }
    }
    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Retangulo");
        }
        public override void Area()
        {
            base.Area();
        }
    }
    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Triangulo");
        }
        public override void Area()
        {
            int area = (Largura * Altura) / 2;
            Console.WriteLine($"Area do Triangulo: {area}");
        }
    }
}
