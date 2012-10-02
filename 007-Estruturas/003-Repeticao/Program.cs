using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            //MostrarWhile();
            //MostrarDo();
            //MostrarFor();
            MostrarForEach();

            Console.ReadKey();
        }

        private static void MostrarForEach()
        {
            //foreach repete um bloco de comandos para cada 
            //elemento de uma coleção enumerável

            //foreach(Tipo item in coleção) { comandos }

            //se comandos tiver apenas uma linha, não
            //usamos { }

            //foreach é read-only, enquanto for é read-write

            var numeros = new int[] { 1, 2, 3, 4, 5 };

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }

        private static void MostrarFor()
        {
            //for repete um bloco de comandos enquanto
            //uma expressão lógica for true

            //for(inicialização;expressão;incremento) {comandos}
            //inicialização: pode criar ou dar valor inicial 
            //a uma variável
            //expressão: determina quando os comandos serão 
            //executados
            //incremento: determina como a(s) variável(is) muda(m) de valor

            //se comandos possuir apenas uma linha, não usamos {}

            for (int i = 1; i <= 5; i++)
                Console.WriteLine("primeiro for: {0}", i);

            for (int i = 1; i <= 5; i++)
                Console.WriteLine("segundo for: {0}", i);

            for (int i = 1, j = 5; i <= 5; i++, j--)
            {
                Console.WriteLine("terceiro for: {0} e {1}", i, j);
            }
        }

        private static void MostrarDo()
        {
            //do repete um bloco de comandos enquanto
            //uma expressão lógica for true

            //do { comandos } while(expressão);

            //a execução do bloco de comandos é feita
            //ANTES da avaliação da expressão

            //se comandos tiver apenas uma linha, 
            //não precisamos usar { }

            int x = 1;

            do
                Console.WriteLine("primeiro do: {0}", x++);
            while (x <= 5);

            do
                Console.WriteLine("segundo do: {0}", x++);
            while (x <= 5);
        }

        private static void MostrarWhile()
        {
            //while repete um bloco de comandos enquanto
            //uma expressão lógica for true

            //while(expressão) { comandos }

            //se comandos tiver apenas uma linha, 
            //não precisamos usar { }

            //a execução do bloco de comandos é feita APÓS 
            //a avaliação da expressão

            int x = 1;

            while (x <= 5)
                Console.WriteLine("primeiro while: {0}", x++);

            while (x <= 5)
                Console.WriteLine("segundo while: {0}", x++);
        }
    }
}
