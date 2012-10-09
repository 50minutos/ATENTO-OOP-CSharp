using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Lambda
{
    class Program
    {
        static Func<DateTime> ObterDataAtual =
            () => DateTime.Now;

        static Func<int, bool> Par =
            x => x % 2 == 0;

        static Func<int, int, int> Somar =
            (x, y) => x + y;

        static void Main(string[] args)
        {
            //representa equações matemáticas
            //entrada => processamento 

            //p => p.Codigo == 1
            //p => p
            //n => 2*n
            //(x, y) => x + y

            Console.WriteLine(ObterDataAtual());
            Console.WriteLine(Par(12));
            Console.WriteLine(Somar(20, 30));

            var s = "O Visual Studio 2012 já foi lançado";

            var digitos = s.Where(c => Char.IsDigit(c));

            foreach (var item in digitos)
                Console.WriteLine(item); 

            var letras = s.Where(SelecionarLetras);

            foreach (var item in letras)
                Console.WriteLine(item);

            Console.ReadKey();
        }

        private static bool SelecionarLetras(char c)
        {
            return Char.IsLetter(c);
        }
    }
}
