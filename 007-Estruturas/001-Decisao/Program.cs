using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Decisao
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarIf();

            MostrarSwitch();

            Console.ReadKey();
        }

        private static void MostrarSwitch()
        {
            //switch - avalia uma expressão lógica e nos permite tomar 
            //UM caminho, dentre vários possíveis

            //switch só trata IGUALDADES

            //sempre que uma opção do switch tiver código, deve
            //ter break; na última linha

            int dia = 2;

            switch (dia)
            {
                case 1: Console.WriteLine("DOM"); break;
                case 2: Console.WriteLine("SEG"); break;
                case 3: Console.WriteLine("TER"); break;
                case 4: Console.WriteLine("QUA"); break;
                case 5: Console.WriteLine("QUI"); break;
                case 6: Console.WriteLine("SEX"); break;
                case 7: Console.WriteLine("SÁB"); break;
                default: Console.WriteLine("ERRO"); break;
            }

            switch (dia)
            {
                case 1:
                case 7: Console.WriteLine("FDS"); break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6: Console.WriteLine("DIA ÚTIL"); break;
                default: Console.WriteLine("ERRO"); break;
            }

            Cor c = Cor.azul;

            switch (c)
            {
                case Cor.vermelho:
                    Console.WriteLine("sua cor é vermelho");
                    break;
                case Cor.verde:
                    Console.WriteLine("sua cor é verde");
                    break;
                case Cor.azul:
                    Console.WriteLine("sua cor é azul");
                    break;
            }
        }

        private static void MostrarIf()
        {
            //if - avalia uma expressão lógica e nos permite tomar
            //UM caminho, de dois possíveis: true ou false

            //if(expressão) 
            //{ comandos para true } 
            //else 
            //{ comandos para false }

            //se o bloco de comandos tem uma linha, não precisamos
            //usar { ... }

            //else { ... } é opcional

            int x = 10;

            if (x == 10)
                Console.WriteLine("x é dez!!!");

            if (x % 2 == 0)
                Console.WriteLine("x é par");
            else
                Console.WriteLine("x é ímpar");

            if (x % 2 == 0)
            {
                x++;
                Console.WriteLine("mudei o valor de x para {0}", x);
            }

            Console.WriteLine(x);
        }
    }

    enum Cor
    { 
        vermelho, verde, azul
    }
}
