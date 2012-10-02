using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //polimorfismo tem como característica podermos criar objetos derivados de uma classe qualquer e atribuí-los à uma variável do tipo base

            //declaração de uma variável
            //t pode fazer referência a objetos do tipo Triangulo
            //OU de qualquer tipo derivado, isto é, Escaleno, Isosceles ou Equilatero
            Triangulo t;

            t = new Escaleno(3, 4, 5);
            Console.WriteLine(t);

            t = new Isosceles(2, 1);
            Console.WriteLine(t);

            t = new Equilatero(1);
            Console.WriteLine(t);

            Console.ReadKey();
        }
    }

    abstract class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalcularPerimetro()
        {
            return A + B + C;
        }

        public double CalcularArea()
        {
            double sp = CalcularPerimetro() / 2;
            return Math.Sqrt(sp * (sp - A) * (sp - B) * (sp - C));
        }

        public override string ToString()
        {
            return String.Format(@"Tipo: {0}
    A: {1}
    B: {2}
    C: {3}
    Perímetro: {4}
    Área: {5}",
                            GetType().Name,
                            A,
                            B,
                            C,
                            CalcularPerimetro(),
                            CalcularArea());
        }
    }

    sealed class Escaleno : Triangulo
    {
        public Escaleno(double a, double b, double c)
            : base(a, b, c)
        {
        }
    }

    sealed class Equilatero : Triangulo
    {
        public Equilatero(double a)
            : base(a, a, a)
        {
        }
    }

    sealed class Isosceles : Triangulo
    {
        public Isosceles(double a, double b)
            : base(a, a, b)
        {
        }
    }
}