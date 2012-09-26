using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_GetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine(x.GetHashCode());

            String nome = "Agnaldo";
            Console.WriteLine("{0:x}", nome.GetHashCode());

            Console.WriteLine();

            var p = new Pessoa() { codigo = x, nome = nome };
            Console.WriteLine("{0:x}", p.GetHashCode());

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int codigo;
        public String nome;

        public override int GetHashCode()
        {
            return 13*codigo*nome.GetHashCode();
        }
    }
}
