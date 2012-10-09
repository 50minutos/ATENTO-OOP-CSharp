using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using _003A_DLL;

namespace _003_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("agnaldo@50minutos.com.br".ChecarEmail());
            Console.WriteLine(new int[] { 1, 2, 3, 4 }.Somar());
            
            Console.ReadKey();
        }
    }
}
