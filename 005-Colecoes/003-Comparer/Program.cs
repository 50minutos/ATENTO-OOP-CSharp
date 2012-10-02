using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = {
                                    new Pessoa(){ Codigo = 1, Nome = "ADÃO"}, 
                                    new Pessoa(){ Codigo = 2, Nome = "EVA"}, 
                                    new Pessoa(){ Codigo = 3, Nome = "CAIM"}, 
                                    new Pessoa(){ Codigo = 4, Nome = "ABEL"}
                               };

            Array.Sort(pessoas, new Comparador());

            foreach (var item in pessoas)
            {
                Console.WriteLine("{0} -> {1}", item.Codigo, item.Nome);
            }

            Array.Sort(pessoas, new Comparison<Pessoa>(Comparar));

            foreach (var item in pessoas)
            {
                Console.WriteLine("{0} -> {1}", item.Codigo, item.Nome);
            }

            Console.ReadKey();
        }

        private static int Comparar(Pessoa x, Pessoa y)
        {
            return x.Codigo.CompareTo(y.Codigo);
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
    }

    class Comparador : IComparer<Pessoa>
    {
        public int Compare(Pessoa x, Pessoa y)
        {
            return x.Nome.CompareTo(y.Nome);
        }
    }
}
