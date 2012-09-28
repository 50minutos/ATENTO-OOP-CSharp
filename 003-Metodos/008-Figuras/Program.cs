using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Posso fazer:
            //Figura f;
            
            //Não posso fazer:
            //f = new Figura();

            Quadrado q = new Quadrado() { X = 2 };
            Console.WriteLine(q);

            Circulo c = new Circulo() { X = 1 };
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }

    //abstract indica que a classe contém pelo menos um membro abstract
    //ou
    //indica que a classe não pode ser instanciada
    abstract class Figura
    {
        public double X { get; set; } //X é lado, X é raio

        //abstract indica que o método DEVE SER sobreposto
        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

        public override string ToString()
        {
            return String.Format("Tipo: {0}\n\tMedida: {1}\n\tÁrea: {2}\n\tPerímetro: {3}", GetType().Name, X, CalcularArea(), CalcularPerimetro());
        }
    }

    class Quadrado : Figura
    {
        public override double CalcularArea() { return Math.Pow(X, 2); }
        public override double CalcularPerimetro() { return 4 * X; }
    }

    class Circulo : Figura
    {
        public override double CalcularArea() { return Math.PI * Math.Pow(X, 2); }
        public override double CalcularPerimetro() { return 2 * Math.PI * X; }
    }
}
