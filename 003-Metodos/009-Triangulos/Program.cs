using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Nããããããããão pode!!!
            //Triangulo t = new Triangulo();

            var escaleno = new Escaleno(3, 4, 5);
            Console.WriteLine(escaleno);

            var equilatero = new Equilatero(1);
            Console.WriteLine(equilatero);

            var isosceles = new Isosceles(2, 1);
            Console.WriteLine(isosceles);

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
    Área: {5}", //string verbatim
                            GetType().Name,
                            A,
                            B,
                            C,
                            CalcularPerimetro(),
                            CalcularArea());
        }
    }

    //sealed indica que a classe NÃO PODE ser herdada
    sealed class Escaleno : Triangulo
    {
        //ctor tab tab
        public Escaleno(double a, double b, double c)
            : base(a, b, c)
        {
        }
    }

    sealed class Equilatero : Triangulo
    {
        //ctor tab tab
        public Equilatero(double a)
            : base(a, a, a)
        {
        }
    }

    sealed class Isosceles : Triangulo
    {
        //ctor tab tab
        public Isosceles(double a /*lado*/, double b /*base*/)
            : base(a, a, b)
        {
        }
    }
}
