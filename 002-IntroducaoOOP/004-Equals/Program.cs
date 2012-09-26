using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p;
            p = new Pessoa();

            p.Codigo = 1; //set
            p.Nome = "ADÃO"; //set

            Console.WriteLine(p.Nome); //get

            Pessoa q = new Pessoa { Codigo = 1, Nome = "ADÃO" };

            Console.WriteLine(p.Equals(q));

            Console.WriteLine(Object.Equals(p, q));
            Console.WriteLine(Object.ReferenceEquals(p, q));

            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(q.GetHashCode());

            Console.ReadKey();
        }
    }

    /// <summary>
    /// classe que representa uma pessoa
    /// </summary>
    class Pessoa
    {
        /*private*/
        int codigo; //field -> campo

        /// <summary>
        /// código da pessoa
        /// </summary>
        public int Codigo //property -> propriedade
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// nome da pessoa
        /// </summary>
        public String Nome //propriedade autoimplementada - o compilador cria o campo e a implementação do get e do set
        {
            get;
            set;
        }

        /// <summary>
        /// compara duas pessoas
        /// </summary>
        /// <param name="obj">Pessoa a ser comparada</param>
        /// <returns>true se todos os campos/propriedades forem iguais</returns>
        public override bool Equals(object obj)
        {
            //regra: se todos os campos forem iguais, retorna true

            Pessoa x = (Pessoa)obj;

            return codigo == x.codigo && Nome == x.Nome;
        }

        /// <summary>
        /// retorna a representação numérida do objeto
        /// </summary>
        /// <returns>número formado por hashcode de codigo e Nome</returns>
        public override int GetHashCode()
        {
            return Math.Abs(Nome.GetHashCode() * codigo * 3);
        }

        //code snippet
        //cw tab tab
        //prop tab tab 

        //CTRL+K, CTRL+X
    }
}
