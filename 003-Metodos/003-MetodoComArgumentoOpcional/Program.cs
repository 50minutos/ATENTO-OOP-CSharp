using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_MetodoComArgumentoOpcional
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo();
            
            Console.WriteLine();
            
            Metodo(y: 1000);
            
            Console.WriteLine();
            
            Metodo(1, 10, 100.1);

            Console.ReadKey();
        }

        static void Metodo(int x = 0, long y = 1, double z = 0.1)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
