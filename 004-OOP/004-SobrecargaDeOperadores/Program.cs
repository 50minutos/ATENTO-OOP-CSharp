using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_SobrecargaDeOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Terreno t1 = new Terreno() { X = 8, Y = 25 };
            Terreno t2 = new Terreno() { X = 10, Y = 20 };

            Console.WriteLine(t1);
            Console.WriteLine(t2);

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 != t2);
            Console.WriteLine(t1.Equals(t2));
            Console.WriteLine(t1.GetHashCode());
            Console.WriteLine(t2.GetHashCode());

            Console.WriteLine();

            var t3 = t1 + t1;
            Console.WriteLine(t3);

            var t4 = t3 + 4;
            Console.WriteLine(t4);

            var t5 = 20 + t4;
            Console.WriteLine(t5);

            Console.ReadKey();
        }
    }

    class Terreno
    {
        public double X { get; set; } //frente
        public double Y { get; set; } //lateral

        public double CalcularArea() { return X * Y; }

        public static Terreno operator +(Terreno t1, Terreno t2)
        {
            //o valor de Y para os dois terrenos deve ser igual
            return new Terreno() { X = t1.X + t2.X, Y = t1.Y };
        }

        public static Terreno operator +(Terreno t, int i)
        {
            return new Terreno() { X = t.X + i, Y = t.Y };
        }

        public static Terreno operator +(int i, Terreno t)
        {
            return new Terreno() { X = t.X + i, Y = t.Y };
        }

        public static bool operator ==(Terreno t1, Terreno t2)
        {
            //dois terrenos são iguais quando as áreas são iguais
            return t1.CalcularArea() == t2.CalcularArea();
        }

        public static bool operator !=(Terreno t1, Terreno t2)
        {
            //dois terrenos são iguais quando as áreas são iguais
            return !(t1 == t2);
        }

        public override bool Equals(object obj)
        {
            Terreno t = (Terreno)obj;
            return this == t;
        }

        public override int GetHashCode()
        {
            return (int)this.CalcularArea();
        }

        public override string ToString()
        {
            return String.Format("X = {0}, Y = {1}, Área = {2}", X, Y, CalcularArea());
        }
    }
}
