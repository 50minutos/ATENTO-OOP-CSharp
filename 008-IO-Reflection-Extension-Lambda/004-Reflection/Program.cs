using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o1 = new ClassePonto<int>(10, 5);

            //new struct só é necessário quando ela contém uma prop
            EstruturaPonto e = new EstruturaPonto();
            e.X = 100;
            e.Y = 50;

            Object o2 = e;

            //MostrarTipo(o1);
            //MostrarTipo(o2);

            //MostrarPropriedades(o1);
            //MostrarPropriedades(o2);

            //MostrarMetodos(o1);
            //MostrarMetodos(o2);

            //MostrarConstrutores(o1);
            //MostrarConstrutores(o2);

            MostrarConteudoDasPropriedades(o1);
            MostrarConteudoDasPropriedades(o2);

            Console.ReadKey();
        }

        private static void MostrarConteudoDasPropriedades(Object o)
        {
            Type t = o.GetType();

            foreach (var item in t.GetProperties())
            {
                Console.WriteLine("{0} -> {1}", item, item.GetValue(o, null));
            }

            Console.WriteLine();
        }

        private static void MostrarConstrutores(Object o)
        {
            Type t = o.GetType();

            foreach (var item in t.GetConstructors())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        private static void MostrarMetodos(Object o)
        {
            Type t = o.GetType();

            foreach (var item in t.GetMethods())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        private static void MostrarPropriedades(Object o)
        {
            Type t = o.GetType();

            foreach (var item in t.GetProperties())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        private static void MostrarTipo(Object o)
        {
            Console.WriteLine(o.GetType()); //retorna um Type

            Console.WriteLine();
        }
    }

    class ClassePonto<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public ClassePonto(T x, T y)
        { 
            X = x; 
            Y = y; 
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", X, Y);
        }
    }

    struct EstruturaPonto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return String.Format("({0}, {1})", X, Y);
        }
    }
}
