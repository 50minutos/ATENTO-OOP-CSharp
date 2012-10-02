using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //array é uma coleção de elementos do mesmo tipo
            //array é indexado e o valor do primeiro índice é ZERO
            //array tem tamanho fixo
            //array é reference type
            //array aceita elementos repetidos

            //declarar
            //Tipo[] nome;

            int[] inteiros;

            //instanciar
            //nome = new Tipo[qtdElementos];

            inteiros = new int[5];

            //percorrer um array
            foreach (var item in inteiros)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            //acessar um elemento do array
            //nome[indice]

            inteiros[0] = 1;
            inteiros[1] = -10;
            inteiros[2] = 100;
            inteiros[3] = -1000;
            inteiros[4] = 10000;

            foreach (var item in inteiros)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            //ordenar
            //Array.Sort(nome);

            Array.Sort(inteiros);

            foreach (var item in inteiros)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            //inverter a posição dos elementos
            //Array.Reverse(nome);

            Array.Reverse(inteiros);

            foreach (var item in inteiros)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            inteiros[0] = 1;

            foreach (var item in inteiros)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            
            //localizar um elemento (primeiro)
            //Array.IndexOf(nome, elemento)

            Console.WriteLine(Array.IndexOf(inteiros, 10));
            Console.WriteLine(Array.IndexOf(inteiros, 1));

            //localizar um elemento (último)
            //Array.LastIndexOf(nome, elemento)

            Console.WriteLine(Array.LastIndexOf(inteiros, 10));
            Console.WriteLine(Array.LastIndexOf(inteiros, 1));



            Console.ReadKey();
        }
    }
}
