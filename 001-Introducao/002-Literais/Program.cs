using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Literais
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor fixo no código
            //sufixo - pode ser maiúsculo ou minúsculo

            Console.WriteLine((1).GetType()); //int
            Console.WriteLine(1.1.GetType()); //double
            Console.WriteLine('X'.GetType()); //char
            Console.WriteLine("Green".GetType()); //String
            Console.WriteLine(1L.GetType()); //long
            Console.WriteLine(1.1F.GetType()); //float
            Console.WriteLine(1.1M.GetType()); //decimal

            Console.ReadKey();
        }
    }
}
