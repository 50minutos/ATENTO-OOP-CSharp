using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_SobrecargaMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Somadora.Somar(1, 1));
            Console.WriteLine(Somadora.Somar(1, 1, 1));

            Console.WriteLine(Somadora.Somar(1L, 1L));

            Console.WriteLine(Somadora.Somar(1.1, 2.2));

            //usa o Somar(double, double)
            Console.WriteLine(Somadora.Somar(1.1F, 2.2F));

            Console.ReadKey();
        }
    }

    class Somadora
    {
        //assinatura: Nome(tipos dos argumentos)

        //Somar(int, int)
        public static int Somar(int x, int y) { return x + y; }

        //Somar(int, int, int)
        public static int Somar(int x, int y, int z) { return x + y + z; }

        //Somar(long, long)
        public static long Somar(long x, long y) { return x + y; }

        //Somar(double, double)
        public static double Somar(double x, double y) { return x + y; }
    }
}
