using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_HerancaComConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b1 = new Base();
            b1.Numero = 10;
            b1.Texto = "dez";

            Base b2 = new Base(20, "vinte");

            Derivada d = new Derivada(30, "trinta");

            Console.WriteLine("{0} = {1}", b1.Numero, b1.Texto);
            Console.WriteLine("{0} = {1}", b2.Numero, b2.Texto);
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

        public Base() { Console.WriteLine("Base()"); }
    }
    
    //cl tab tab
    class Derivada : Base
    {
        public DateTime Data { get; private set; }

        public Derivada(int numero, String texto)
        {
            Console.WriteLine("Derivada(int, String)");

            Numero = numero;
            Texto = texto;
            Data = DateTime.Now;
        }
    }

    //github.com
    //dropbox.com
}
