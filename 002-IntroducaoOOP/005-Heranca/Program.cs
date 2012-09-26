using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Ponto { X = 10, Y = 5 };
            Console.WriteLine(p);

            var q = new Ponto3D { X = 10, Y = 5, Z = 1 };
            Console.WriteLine(q);

            Console.ReadKey();
        }
    }

    class Ponto //herda de Object
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return String.Format("({0}, {1})", X, Y);
        }
    }

    class Ponto3D : Ponto //herda de ponto
    {
        public int Z { get; set; }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}
