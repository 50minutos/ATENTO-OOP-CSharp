using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_MetodoComArgumentoOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("antes: {0}", x);
            Dobrar(x);
            Console.WriteLine("depois: {0}", x);

            Console.WriteLine();

            Object o = 10;
            Console.WriteLine("antes: {0}", o);
            Dobrar(o);
            Console.WriteLine("depois: {0}", o);

            Console.WriteLine();

            double d = 10;
            Console.WriteLine("antes: {0}", d);
            d = Dobrar(d); //AQUI TEM ATRIBUIÇÃO!!!
            Console.WriteLine("depois: {0}", d);

            Console.WriteLine();

            int resultado;
            Somar(10, 40, out resultado);
            Console.WriteLine("{0}minutos", resultado);

            Console.ReadKey();
        }

        //quando passamos um value type para um método
        //e alteramos o seu conteúdo, isso não afeta
        //o value type original
        static void Dobrar(int x) { x *= 2; } //value type

        static void Dobrar(Object x) //reference type
        {
            //F9 - liga/desliga breakpoint
            //F11 - executa passo-a-passo
            var i = (int)x;        
            i *= 2;
            x = i;
        }

        static double Dobrar(double x) { return x * 2; }

        //out indica que o argumento é de saída 
        static void Somar(int x, int y, out int z)
        {
            //esse argumento NÃO PODE SER LIDO
            //Console.WriteLine(z);

            z = x + y;
        }
    }
}
