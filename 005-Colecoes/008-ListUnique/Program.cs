using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_ListUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar uma lista de Strings que NÃO ACEITE ELEMENTOS REPETIDOS

            var lista = new ListUnique<String>();

            lista.Add("adão");
            lista.Add("adão");
            lista.Add("eva");

            foreach (var item in lista)
                Console.WriteLine(item);
     
            Console.ReadKey();
        }
    }

    class ListUnique<T> : List<T>
    {
        public new void Add(T t)
        {
            if (!Contains(t)) base.Add(t);
        }
    }
}
