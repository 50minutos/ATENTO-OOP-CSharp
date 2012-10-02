using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[4];

            foreach (var item in pessoas) Console.WriteLine(item);

            pessoas[0] = new Pessoa() { Nome = "adão" };
            pessoas[1] = new Pessoa() { Nome = "eva" };
            pessoas[2] = new Pessoa() { Nome = "caim" };
            pessoas[3] = new Pessoa() { Nome = "abel" };

            foreach (var item in pessoas) Console.WriteLine(item);

            Array.Sort(pessoas);

            foreach (var item in pessoas) Console.WriteLine(item);

            Console.WriteLine((1).CompareTo(5));
            Console.WriteLine((1).CompareTo(1));
            Console.WriteLine((5).CompareTo(1));

            Console.ReadKey();
        }
    }

    class Pessoa : IComparable<Pessoa>
    {
        public String Nome { get; set; }

        public override String ToString() { return Nome; }

        public int CompareTo(Pessoa other)
        {
            return Nome.CompareTo(other.Nome);
        }
    }
}
