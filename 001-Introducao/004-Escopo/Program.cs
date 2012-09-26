using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x);

            {
                //não posso fazer:
                //int x = 100;
                Console.WriteLine(x);

                int y = 100;
                Console.WriteLine(y);
            }

            {
                int y = 1000;
                Console.WriteLine(y);
            }

            {
                x = 0;
                Console.WriteLine(x);
            }

            Console.WriteLine(x);

            //não posso fazer:
            //Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
