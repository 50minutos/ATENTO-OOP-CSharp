using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Generico
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = { 
                                   new Pessoa(){ Nome = "Adão"}, 
                                   new Pessoa(){ Nome = "Eva"}, 
                                   new Pessoa(){ Nome = "Caim"}, 
                                   new Pessoa(){ Nome = "Abel"}
                               };

            Bola[] bolas = { 
                                new Bola{ TipoEsporte = "Tênis de mesa" }, 
                                new Bola{ TipoEsporte = "Futebol" }
                           };

            Imprimir(pessoas);
            Imprimir(bolas);
            Imprimir(new int[] { 1, 2, 3, 4, 5 });

            Console.ReadKey();
        }

        //private static void Imprimir(Bola[] bolas)
        //{
        //    foreach (var item in bolas)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.WriteLine();
        //}

        //private static void Imprimir(Pessoa[] pessoas)
        //{
        //    foreach (var item in pessoas)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.WriteLine();
        //}

        private static void Imprimir<T>(T[] objetos)
        {
            foreach (var item in objetos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }

    class Pessoa
    {
        public String Nome { get; set; }
        public override string ToString() { return Nome; }
    }

    class Bola
    {
        public String TipoEsporte { get; set; }
        public override string ToString() { return TipoEsporte; }
    }
}
