using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_MetodoComArgumentoRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Console.WriteLine("antes: {0}", x);

            Dobrar(ref x);

            Console.WriteLine("depois: {0}", x);

            //fazer um método que troque o valor de duas int

            int y = 1;

            Trocar(ref x, ref y); //Swap

            Console.WriteLine("x = {0} e y = {1}", x, y);

            Console.ReadKey();
        }

        private static void Trocar(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        //static int Dobrar(int x) { return x * 2; }
        //static void Dobrar(int x, out int y) { y = x * 2; }

        static void Dobrar(ref int x) { x *= 2; }
    }
}
