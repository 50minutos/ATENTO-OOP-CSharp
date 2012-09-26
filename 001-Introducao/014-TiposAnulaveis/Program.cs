using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _014_TiposAnulaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //estruturas que podem receber null

            //declarar
            //Tipo? nome;

            int? x;
            x = 10;

            Console.WriteLine(x.HasValue ? x.Value : 0);

            x = null;

            Console.WriteLine(x.HasValue ? x.Value : 0);

            Console.WriteLine(x ?? 0); //OPERADOR COALESCE

            int y = x.HasValue ? x.Value : 0;

            Console.WriteLine(y);

            Nullable<int> z = x;
            
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
