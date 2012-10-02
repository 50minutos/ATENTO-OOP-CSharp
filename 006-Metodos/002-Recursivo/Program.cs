using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Recursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //soma de todos os números entre 1 e x

            Console.WriteLine(Somar(10));
            Console.WriteLine(SomarR(10));
            
            Console.WriteLine(Fatorial(10));

            Console.ReadKey();
        }

        //não recursivo
        static int Somar(int x)
        {
            int retorno = 0;

            for (int i = 1; i <= x; i++)
            {
                retorno += i;
            }

            return retorno;
        }

        //recursivo
        static int SomarR(int x)
        {
            return x == 1 ? 1 : x + SomarR(x - 1);
        }
 
        //recursivo
        static int Fatorial(int x)
        {
            return x == 0 ? 1 : x * Fatorial(x - 1);
        }
    }

}
