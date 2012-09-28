using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010_HerancaComConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base(20, "vinte");

            Derivada d = new Derivada(30, "trinta");

            Console.WriteLine("{0} = {1}", b.Numero, b.Texto);
            Console.WriteLine("{0} = {1} - hora atual = {2}", d.Numero, d.Texto, d.Data);

            Console.ReadKey();
        }
    }

    class Base
    {
        //prop tab tab
        public int Numero { get; set; }
        public String Texto { get; set; }

        //ctor tab tab
        public Base(int numero, String texto)
        {
            Console.WriteLine("Base(int, String)");

            Numero = numero;
            Texto = texto;
        }
    }

    //cl tab tab
    class Derivada : Base
    {
        public DateTime Data { get; private set; }

        public Derivada(int numero, String texto)
            : base(numero, texto)
        {
            Console.WriteLine("Derivada(int, String)");
            
            Data = DateTime.Now;
        }
    }
}
