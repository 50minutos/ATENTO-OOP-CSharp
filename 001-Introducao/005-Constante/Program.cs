using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_Constante
{
    class Program
    {
        static void Main(string[] args)
        {
            //constante é um valor que o compilador usa como literal no código

            //declarar
            //const Tipo NOME_CONSTANTE = conteudo;

            const String COR_DO_SANGUE = "vermelho";
            const double PI = 3.141592;
            const float E /*número de Euler*/= 2.718281828459045F;

            Console.WriteLine("O sangue é {0}", COR_DO_SANGUE);
            Console.WriteLine("O valor de PI é {0}", PI);
            Console.WriteLine("E é {0}", E);

            //Não posso fazer:
            //COR_DO_SANGUE = "ROXO";

            Console.ReadKey();

            //descompiladores para .net:
            //REFLECTOR (RED GATE)
            //JUST DECOMPILE (TELERIK)
        }
    }
}
