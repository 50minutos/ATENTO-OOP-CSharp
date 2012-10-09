using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Classe();
            c = null;

            //sugerindo ao Garbage Collector que temos objetos para descarte
            GC.Collect();

            Console.WriteLine();

            var o1 = new Outra();
            o1.Dispose();

            using (var o2 = new Outra())
            {
                Console.WriteLine("trabalhando...");
            }

            Console.ReadKey();
        }
    }

    class Classe
    {
        //construtor
        public Classe() { Console.WriteLine("passei no construtor"); }

        //destrutor -> Finalize()
        ~Classe() { Console.WriteLine("passei no destrutor"); }
    }

    class Outra : IDisposable
    { 
        //construtor
        public Outra() { Console.WriteLine("passei no construtor"); }

        public void Dispose() { Console.WriteLine("passei no dispose"); }
    }
}
