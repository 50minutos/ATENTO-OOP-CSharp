using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new Objeto();
            o.campo = "conteúdo de o";

            var p = new Objeto();
            p.campo = "conteúdo de p";

            Console.WriteLine(o);
            Console.WriteLine(p);

            Console.WriteLine();

            //inicializador de objeto
            var a = new Pessoa() 
                { codigo = 1, nome = "ADÃO" };

            var b = new Pessoa() 
                { codigo = 2, nome = "EVA" };

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }

    class Objeto
    {
        internal String campo; //field -> campo

        public override String ToString() //method -> método
        {
            return campo;
        }
    }

    class Pessoa
    {
        internal int codigo;
        internal String nome;

        public override String ToString()
        {
            return String.Format("{0} -> {1}", codigo, nome);
        }
    }
}
