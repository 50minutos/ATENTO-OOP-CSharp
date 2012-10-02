using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_Equacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //uma equação do segundo grau possuiu a forma:
            //ax² + bx + c = 0 onde:
            //a é diferente de zero

            double a = 1;
            double b = 0;
            double c = -1;

            //cálculo de delta: b² -4ac
            //temos 3 opções:
            //delta < 0 -> não existe solução em R
            //delta = 0 -> existe uma solução: (-b + raiz(delta))/2a
            //delta > 0 -> existem duas soluções: (-b + raiz(delta))/2a e (-b - raiz(delta))/2a

            if (a == 0)
                Console.WriteLine("não é equação do segundo grau");
            else
            {
                double d = b * b - 4 * a * c;

                if (d < 0)
                    Console.WriteLine("não existe solução em R");
                else
                    if (d == 0)
                        Console.WriteLine("x1 = {0}", (-b + Math.Sqrt(d)) / (2 * a));
                    else
                        Console.WriteLine("x1 = {0} e x2 = {1}", (-b + Math.Sqrt(d)) / (2 * a), (-b - Math.Sqrt(d)) / (2 * a));
            }

            Console.ReadKey();
        }
    }
}
