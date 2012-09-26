using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _013_OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            //?:
            //condição ? true : false

            double salario = 1000;
            bool casado = false;
            bool divorciado = true;

            salario *= casado //condição é verdadeira?
                ? 1.05 //então 1.05
                : divorciado //não casado e divorciado?
                    ? .7 //então 0.7
                    : 1.2; //senão 1.2

            Console.WriteLine(salario);

            Console.ReadKey();
        }
    }
}
