using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_ConstrutorComParametroOpcional
{
    class Program
    {
        static void Main(string[] args)
        {
            var livro = new Livro(1, "C# é bico");
            
            Console.WriteLine(livro);

            var outro = new Livro(2, "Aprenda C# - é questão de dias: uns 8.000", preco: 120.32);
            //parametro/argumento nomeado (nome: conteudo)
            
            Console.WriteLine(outro);

            Console.ReadKey();
        }
    }

    class Livro
    {
        public int Codigo { get; set; }
        public String Titulo { get; set; }
        public int QuantidadePaginas { get; set; }
        public double Preco { get; set; }

        public Livro(int codigo, String titulo, int qtd = 0, double preco = 0)
        {
            Codigo = codigo;
            Titulo = titulo;
            QuantidadePaginas = qtd;
            Preco = preco;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.Codigo, this.Titulo, this.QuantidadePaginas, this.Preco);
        }
    }
}
