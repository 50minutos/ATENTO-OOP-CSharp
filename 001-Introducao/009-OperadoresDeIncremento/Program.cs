using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_OperadoresDeIncremento
{
    class Program
    {
        static void Main(string[] args)
        {
            //++ --

            //int x = 10;

            //x = x + 1;
            //ou
            //x += 1;
            //ou
            //x++; //pós incremento
            //ou
            //++x; //pré incremento

            //Console.WriteLine(x);  //11 para todos 

            int x = 10;

            Console.WriteLine(x++); //imprime 10 e depois x = 11
            Console.WriteLine(++x); //x = 12 e depois imprime 12
            Console.WriteLine(x--); //imprime 12 e depois x = 11
            Console.WriteLine(--x); //x = 10 e depois imprime 10

            Console.WriteLine(x);

            Console.WriteLine();

            //Console.WriteLine(x += ++x); //21
            
            //maldade:
            Console.WriteLine(x += x++); //20
            Console.WriteLine(x); //20

            Console.ReadKey();
        }
    }
}
