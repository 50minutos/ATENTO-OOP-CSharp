using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIFO - last in first out

            var pilha = new Stack<String>();
        
            pilha.Push("prato");
            pilha.Push("bandeja");
            pilha.Push("prato");
            pilha.Push("panela");

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(pilha.Peek());
            Console.WriteLine(pilha.Peek());
            Console.WriteLine(pilha.Peek());

            Console.WriteLine();

            while(pilha.Count>0)
                Console.WriteLine(pilha.Pop());

            Console.WriteLine(pilha.Count);

            Console.ReadKey();
        }
    }
}
