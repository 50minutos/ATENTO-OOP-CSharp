using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Somar(1, 2));

            int[] inteiros = { 1, 2 };
            Console.WriteLine(Somar(inteiros));

            Console.WriteLine(Somar(new int[] { 1, 2 }));

            Console.WriteLine(Somar(1, 2, 3, 4, 5, 6, 7, 78));

            Console.ReadKey();
        }

        static int Somar(params int[] numeros)
        {
            int retorno = 0;

            foreach (var item in numeros)
                retorno += item;

            return retorno;
        }
    }
}
