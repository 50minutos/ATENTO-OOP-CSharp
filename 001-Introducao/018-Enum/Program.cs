using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _018_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordenada sp;
           
            sp.latitude.g = 23;
            sp.latitude.m = 32;
            sp.latitude.d = PontoCardeal.S; //S
           
            sp.longitude.g = 46;
            sp.longitude.m = 38;
            sp.longitude.d = PontoCardeal.W; //W

            Console.WriteLine(sp);

            Console.ReadKey();
        }
    }
}
