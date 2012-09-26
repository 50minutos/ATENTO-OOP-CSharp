using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            //um caixa eletrônico tem moeda de R$ 1,00 e cédulas de R$ 2,00, R$ 5,00, R$ 10,00, R$ 20,00, R$ 50,00 e R$ 100,00
            //calcular quantas cédulas/moedas são entregues para um determinado valor

            int v = 1808;

            Console.WriteLine("{0,4} x R$ 100,00", v / 100); v %= 100;
            Console.WriteLine("{0,4} x R$  50,00", v / 50); v %= 50;
            Console.WriteLine("{0,4} x R$  20,00", v / 20); v %= 20;
            Console.WriteLine("{0,4} x R$  10,00", v / 10); v %= 10;
            Console.WriteLine("{0,4} x R$   5,00", v / 5); v %= 5;
            Console.WriteLine("{0,4} x R$   2,00", v / 2); v %= 2;
            Console.WriteLine("{0,4} x R$   1,00", v);

            Console.ReadKey();
        }
    }
}
