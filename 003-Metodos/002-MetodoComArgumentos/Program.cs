using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_MetodoComArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var soma = new Calculadora().Somar(1, 2);
            var diferenca = new Calculadora().Subtrair(1, 2);
            var produto = Calculadora.Multiplicar(10, 2);
            var razao = Calculadora.Dividir(3, 7);

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", 
                soma, diferenca, produto, razao);

            Console.ReadKey();
        }
    }

    class Calculadora
    {
        internal double Somar(int x, int y) { return x + y; }
        internal double Subtrair(int x, int y) { return x - y; }
        internal static double Multiplicar(int x, int y) { return x * y; }
        internal static double Dividir(int x, int y) { return (double)x / y; }
    }
}
