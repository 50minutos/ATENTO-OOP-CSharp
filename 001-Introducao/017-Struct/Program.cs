using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _017_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p;
            
            p.x = 10;
            p.y = 5;

            Console.WriteLine(p);

            Ponto3D q;

            q.x = 10; 
            q.y = 5;
            q.z = 1;

            Console.WriteLine(q);

            Console.ReadKey();
        }
    }
}
