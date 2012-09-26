using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //variável é um apelido para um endereço de memória
            //o conteúdo desse endereço pode ser alterado

            //declarar
            //Tipo nomeDaVariavel;

            int numero;
            float numeroPontoFlutuante;
            bool b;
            char sexo;

            //atribuir
            //nomeDaVariavel = conteudo;

            numero = 10;
            numeroPontoFlutuante = 1.565F;
            b = false;
            sexo = 'M';

            Console.WriteLine(numero + numeroPontoFlutuante);
            Console.WriteLine(b);
            Console.WriteLine(sexo);

            //variável tipada implicitamente -> implicitly typed variable
            //var nome = conteudo;

            var x = 10; //int x = 10;
            var s = "opa... bom dia..."; //String s = "opa... bom dia...";

            //não podemos usar:
            //var v;
            //var v = null;

            Console.WriteLine(x.GetType().Name);
            Console.WriteLine(s.GetType().Name);

            //declaração múltipla
            //Tipo nome1, nome2, nome3 ...

            int i, j, k;

            //atribuição múltipla
            // nome1 = nome2 = nome3 = ... = conteudo

            i = j = k = 1000;

            Console.WriteLine("{0} {1} {2}", i, j, k);

            Console.WriteLine("{0}-{0}-{0}", "blá");

            //declaração e atribuição
            //Tipo nome = conteudo;

            float f = 10.45f;

            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
