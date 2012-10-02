using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p1 = new Pessoa();

            //p1.Codigo = 1;
            //p1.Nome = "Adão";

            //Pessoa p2 = p1;

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            //p2.Codigo = 2;
            //p2.Nome = "Eva";

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            //Pessoa p1 = new Pessoa();

            //p1.Codigo = 1;
            //p1.Nome = "Adão";

            //Pessoa p2 = new Pessoa();

            //p2.Codigo = p1.Codigo;
            //p2.Nome = p1.Nome;

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            //p2.Codigo = 2;
            //p2.Nome = "Eva";

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            PessoaClonavel p1 = new PessoaClonavel();

            p1.Codigo = 1;
            p1.Nome = "Adão";

            PessoaClonavel p2 = (PessoaClonavel)p1.Clone();
            
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            p2.Codigo = 2;
            p2.Nome = "Eva";

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        public override string ToString()
        {
            return String.Format("{0} -> {1}", Codigo, Nome);
        }
    }

    class PessoaClonavel : ICloneable
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        public override string ToString()
        {
            return String.Format("{0} -> {1}", Codigo, Nome);
        }

        public Object Clone()
        {
            return MemberwiseClone();
        }
    }
}
