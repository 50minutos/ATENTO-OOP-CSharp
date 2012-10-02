using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface define que membros são obrigatórios nos 
            //tipos derivados

            Aviao a = new Aviao();
            a.Modelo = "F-117";
            Console.WriteLine(a.Modelo);
            a.Voar();

            Console.WriteLine();

            Helicoptero h = new Helicoptero() { Prefixo = "PP-ESS" };
            Console.WriteLine(h.Prefixo);
            h.Voar();

            Console.WriteLine();

            Marreco m = new Marreco();
            m.Voar();
            m.Nadar();

            Console.WriteLine();

            Abelha abelha = new Abelha();
            abelha.Voar();

            Console.ReadKey();
        }
    }

    interface IVoador
    {
        void Voar();
    }

    interface INadador
    {
        void Nadar();
    }

    class Aviao : IVoador //implementa IVoador
    {
        public String Modelo { get; set; }

        //implementação do método Voar da IVoador
        public void Voar() { Console.WriteLine("O avião voou"); }
    }

    class Helicoptero : IVoador
    {
        public String Prefixo { get; set; }

        public void Voar() { Console.WriteLine("O helicóptero voou"); }
    }

    class Marreco : IVoador, INadador
    {
        public void Voar() { Console.WriteLine("O marreco voou"); }
        public void Nadar() { Console.WriteLine("O marreco nadou"); }
    }

    abstract class InsetoVoador : IVoador 
    {
        public abstract void Voar();   
    }

    class Abelha : InsetoVoador
    {
        public override void Voar() { Console.WriteLine("a abelha voou"); }
    }
}
