using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var fila = new Queue<String>();
            
            fila.Enqueue("adão");
            fila.Enqueue("eva");
            fila.Enqueue("caim");
            fila.Enqueue("abel");

            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Peek());

            Console.WriteLine();

            while(fila.Count > 0)
                Console.WriteLine(fila.Dequeue());

            Console.WriteLine(fila.Count);

            //FIFO -> first in first out

            Console.ReadKey();
        }
    }
}
