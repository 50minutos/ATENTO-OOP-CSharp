using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _016_CheckedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = Byte.MaxValue;

            Console.WriteLine(x);

            //unchecked é o modo default!!!

            //checked //força overflow em operações matemáticas
            //{
                x += 100;
            //}

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
