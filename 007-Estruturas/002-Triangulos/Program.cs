using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            //um triangulo é definido por:
            //tem 3 lados
            //todos os lados tem valor maior que zero
            //a soma de dois lados é sempre maior que o outro lado

            int a = 3;
            int b = 4;
            int c = 5;

            // 1 1 1 = equilátero
            // 2 2 1 = isósceles
            // 3 4 5 = escaleno
            // 0 2 2 = não é
            // 1 1 2 = não é 

            //ver se: é triângulo válido
            //escrever na tela o tipo do triângulo (escaleno, isósceles, equilátero)

            if (a <= 0 || b <= 0 || c <= 0 
                || a + b <= c || a + c <= b || b + c <= a)
                Console.WriteLine("não é triângulo");
            else
                if (a == b && b == c)
                    Console.WriteLine("é um triângulo equilátero");
                else
                    if (a != b && b != c && a != c)
                        Console.WriteLine("é um triângulo escaleno");
                    else
                        Console.WriteLine("é um triângulo isósceles");

            Console.ReadKey();
        }
    }
}
