using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> hashSet = new HashSet<String>();

            hashSet.Add("adão");
            hashSet.Add("adão");
            hashSet.Add("eva");

            foreach (var item in hashSet)
                Console.WriteLine(item);

            var pessoas = new HashSet<Pessoa>() 
            {
                new Pessoa(){ Nome="ADÃO" }, 
                new Pessoa(){ Nome="ADÃO" }, 
                new Pessoa(){ Nome="EVA" } 
            };

            foreach (var item in pessoas)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }

    class Pessoa 
    {
        public String Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }

        public override bool Equals(object obj)
        {
            return Nome.Equals(((Pessoa)obj).Nome);
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
    }
}
