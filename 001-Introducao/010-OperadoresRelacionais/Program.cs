using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010_OperadoresRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //== != > >= < <=

            int x = 10;
            int y = 5;

            Console.WriteLine(x == y); //false
            Console.WriteLine(x == y * 2); //true
            Console.WriteLine(x != y); //true
            Console.WriteLine(x / 2 != y); //false
            Console.WriteLine(x > y); //true
            Console.WriteLine(2 * x >= y * 4); //true
            Console.WriteLine(x < y); //false
            Console.WriteLine(2 * x <= y * 4); //true

            Console.ReadKey();
        }
    }
}
