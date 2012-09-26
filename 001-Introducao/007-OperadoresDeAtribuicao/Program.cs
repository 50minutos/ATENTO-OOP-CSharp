using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //= += -= *= /= %= ...

            int x;
            byte y;
            long z;

            //erro:
            //x = y = z = 10;

            z = x = y = 10;

            Console.WriteLine(x);

            Console.WriteLine(x += 10); // x = x + 10 -> 20
            Console.WriteLine(x -= 3); // x = x - 3 -> 17
            Console.WriteLine(x *= 2); // x = x * 2 -> 34
            Console.WriteLine(x /= 17); // x = x / 17 -> 2
            Console.WriteLine(x %= 2); // x = x % 2 -> 0

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
