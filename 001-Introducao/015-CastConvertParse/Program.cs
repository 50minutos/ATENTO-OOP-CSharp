using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _015_CastConvertParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversão implícita - compilador e é feita quando não há possibilidade de perda de dados
            //conversão explícita

            int x = 10; 
            //00000000 00000000 
            //00000000 00001010
            
            long y = x; 
            //00000000 00000000 
            //00000000 00000000 
            //00000000 00000000 
            //00000000 00001010

            Console.WriteLine("{0} e {1}", x, y);

            byte z = (byte)y;
            //00001010

            Console.WriteLine(z);

            double d = 1.1;

            x = (int)d;

            Console.WriteLine(x);

            String s = "123";

            x = Int32.Parse(s);

            Console.WriteLine(x);
            
            s = d.ToString();

            Console.WriteLine(s);

            int i = 65;
            char c = (char)i;

            Console.WriteLine(c);

            Object o = "3432";

            x = Convert.ToInt32(o);

            Console.ReadKey();
        }
    }
}
